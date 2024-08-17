using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCoCaRo
{
	public class ChessBoardManager
	{
		#region Properties
		private Panel chessBroad;
		public Panel ChessBroad
		{
			get { return chessBroad; }
			set { chessBroad = value; }
		}

		private List<Player> player;
		public List<Player> Player
		{
			get { return player; }
			set { player = value; }
		}

		private int currentPlayer;
		public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

		private PictureBox PlayerMark;
		public PictureBox PlayerMark1 { get => PlayerMark; set => PlayerMark = value; }

		private List<List<Button>> matrix;
		public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

		private event EventHandler playerMarked;
		public event EventHandler PlayerMarked
		{
			add
			{
				playerMarked += value;
			}
			remove
			{
				playerMarked -= value;
			}
		}

		private event EventHandler endedGame;
		public event EventHandler EnderGame
		{
			add
			{
				endedGame += value;
			}
			remove
			{
				endedGame -= value;
			}
		}
		#endregion

		#region Initialize
		public ChessBoardManager(Panel chessBroad,TextBox playerName, PictureBox mark)
		{
			this.chessBroad = chessBroad;
			this.PlayerName = playerName;
			this.PlayerMark1 = mark;
			this.player = new List<Player>()
			{
				new Player("DuyAnh",Image.FromFile(Application.StartupPath + "\\images\\p1.png")),
				new Player("TanToan",Image.FromFile(Application.StartupPath + "\\images\\p2.png"))
			};
			
		}
		private TextBox PlayerName;
		#endregion

		#region Methods
		public void DrawChessBroad()
		{
			chessBroad.Enabled = true;
			chessBroad.Controls.Clear();
			currentPlayer = 0;
			ChangePlayer();
			Matrix = new List<List<Button>>();

			Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
			for (int i = 0; i < Cons.Chess_broad_height; i++)
			{
				Matrix.Add(new List<Button>());
				for (int j = 0; j < Cons.Chess_broad_width; j++)
				{
					Button btn = new Button()
					{
						Width = Cons.Chess_Width,
						Height = Cons.Chess_Height,
						Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
						BackgroundImageLayout = ImageLayout.Stretch,
						Tag = i.ToString()
					};

					btn.Click += btn_Click;
					
					chessBroad.Controls.Add(btn);

					Matrix[i].Add(btn);

					oldButton = btn;
				}
				oldButton.Location = new Point(0, oldButton.Location.Y + Cons.Chess_Height);
				oldButton.Width = 0;
				oldButton.Height = 0;
			}

		}

		private void btn_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (btn.BackgroundImage != null)
				return;
			Mark(btn);
			ChangePlayer();

			if (playerMarked != null)
				playerMarked(this, new EventArgs());

			if (isEndGame(btn))
            {
                EndGame();
            }
			
		}

		public void EndGame()
		{
            if (endedGame!= null)
			endedGame(this,new EventArgs());
        }

		private bool isEndGame(Button btn)
		{
			return isEndHangNgang(btn) || isEndHangDoc(btn) || isEndDuongCheoChinh(btn) || isEndDuongCheoPhu(btn);
		}

		private Point GetChessPoint(Button btn)
		{
			int hangDoc= Convert.ToInt32(btn.Tag);
			int hangNgang = Matrix[hangDoc].IndexOf(btn);

			Point point=new Point(hangNgang,hangDoc);
			return point;
		}

		private bool isEndHangNgang(Button btn)
		{
			Point point = GetChessPoint(btn);
			int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
				if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
				{
					countLeft++;
				}
				else
					break;
            }

            int countRight = 0;
			for (int i = point.X + 1 ; i < Cons.Chess_broad_width; i++)
			{
				if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
				{
					countRight++;
				}
				else
					break;
			}
			return countLeft + countRight == 5;
		}
		private bool isEndHangDoc(Button btn)
		{
			Point point = GetChessPoint(btn);
			int countTop = 0;
			for (int i = point.Y; i >= 0; i--)
			{
				if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
				{
					countTop++;
				}
				else
					break;
			}

			int countBottom = 0;
			for (int i = point.Y + 1; i < Cons.Chess_broad_height; i++)
			{
				if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
				{
					countBottom++;
				}
				else
					break;
			}
			return countTop + countBottom == 5;
		}

		private bool isEndDuongCheoChinh(Button btn)
		{
			Point point = GetChessPoint(btn);
			int countTop = 0;
			for (int i = 0; i <= point.X; i++)
			{
				if (point.X - i < 0 || point.Y - i < 0)
					break;

				if (Matrix[point.Y-i][point.X-i].BackgroundImage == btn.BackgroundImage)
				{
					countTop++;
				}
				else
					break;
			}

			int countBottom = 0;
			for (int i = 1; i <=Cons.Chess_broad_width - point.X; i++)
			{
				if (point.Y + i >= Cons.Chess_broad_height || point.X + i >= Cons.Chess_broad_width)
					break;

				if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
				{
					countBottom++;
				}
				else
					break;
			}
			return countTop + countBottom == 5;
		}
		private bool isEndDuongCheoPhu(Button btn)
		{
			Point point = GetChessPoint(btn);
			int countTop = 0;
			for (int i = 0; i <= point.X; i++)
			{
				if (point.X + i > Cons.Chess_broad_width || point.Y - i < 0)
					break;

				if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
				{
					countTop++;
				}
				else
					break;
			}

			int countBottom = 0;
			for (int i = 1; i <= Cons.Chess_broad_width - point.X; i++)
			{
				if (point.Y + i >= Cons.Chess_broad_height || point.X - i <0 )
					break;

				if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
				{
					countBottom++;
				}
				else
					break;
			}
			return countTop + countBottom == 5;
		}
		private void Mark(Button btn)
		{
			btn.BackgroundImage = player[currentPlayer].Mark;
			currentPlayer = currentPlayer == 1 ? 0 : 1;
		}
		private void ChangePlayer()
		{
			PlayerName.Text = player[currentPlayer].Name;
			PlayerMark1.Image = player[currentPlayer].Mark;
		}
		#endregion

	}
}
