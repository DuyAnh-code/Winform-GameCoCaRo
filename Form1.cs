using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCoCaRo
{
	public partial class Form1 : Form
	{
		#region Properties
		ChessBoardManager chessBroad;
		#endregion
		public Form1()
		{
			InitializeComponent();
			chessBroad=new ChessBoardManager(pnlChessBroad, txtPlayerName, pctbMark);
			chessBroad.EnderGame += ChessBroad_EnderGame;
			chessBroad.PlayerMarked += ChessBroad_PlayerMarked;


			prcbCoolDown.Step = Cons.CoolDown_Step;
			prcbCoolDown.Maximum = Cons.CoolDown_Time;
			prcbCoolDown.Value = 0;
			tmCoolDown.Interval= Cons.CoolDown_Interval;

			NewGame();

			
		}
		#region Methods

		void EndGame()
		{
			tmCoolDown.Stop();
			pnlChessBroad.Enabled = false;
			MessageBox.Show("Kết thúc!");
		}

		void NewGame()
		{
			chessBroad.DrawChessBroad();
			prcbCoolDown.Value=0;
			tmCoolDown.Stop();
		}
		
		void Quit()
		{
			Application.Exit();
		}

		void Undo()
		{

		}
			

		 void ChessBroad_PlayerMarked(object sender, EventArgs e)
		{
			tmCoolDown.Start();
			prcbCoolDown.Value = 0;
		}

		 void ChessBroad_EnderGame(object sender, EventArgs e)
		{
			EndGame();
		}

		 void tmCoolDown_Tick(object sender, EventArgs e)
		{

			prcbCoolDown.PerformStep();

			if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
			{
				tmCoolDown.Stop();
				EndGame();
				
			}
		}

		private void menuToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewGame();
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Undo();
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Quit();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn muốn thoát game ?","Thông báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            
			e.Cancel = true;
		}
		#endregion
	}
}