namespace GameCoCaRo
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pnlChessBroad = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pctbAvatar = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPlayerName = new System.Windows.Forms.TextBox();
			this.pctbMark = new System.Windows.Forms.PictureBox();
			this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlChessBroad
			// 
			this.pnlChessBroad.BackColor = System.Drawing.SystemColors.Control;
			this.pnlChessBroad.Location = new System.Drawing.Point(356, 41);
			this.pnlChessBroad.Name = "pnlChessBroad";
			this.pnlChessBroad.Size = new System.Drawing.Size(631, 545);
			this.pnlChessBroad.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pctbAvatar);
			this.panel2.Location = new System.Drawing.Point(15, 41);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(335, 309);
			this.panel2.TabIndex = 1;
			// 
			// pctbAvatar
			// 
			this.pctbAvatar.BackColor = System.Drawing.SystemColors.Control;
			this.pctbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pctbAvatar.Image")));
			this.pctbAvatar.Location = new System.Drawing.Point(3, 3);
			this.pctbAvatar.Name = "pctbAvatar";
			this.pctbAvatar.Size = new System.Drawing.Size(329, 303);
			this.pctbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctbAvatar.TabIndex = 0;
			this.pctbAvatar.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.prcbCoolDown);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.txtPlayerName);
			this.panel3.Controls.Add(this.pctbMark);
			this.panel3.Location = new System.Drawing.Point(12, 356);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(338, 230);
			this.panel3.TabIndex = 2;
			// 
			// prcbCoolDown
			// 
			this.prcbCoolDown.Location = new System.Drawing.Point(163, 65);
			this.prcbCoolDown.Name = "prcbCoolDown";
			this.prcbCoolDown.Size = new System.Drawing.Size(172, 43);
			this.prcbCoolDown.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Rockstone", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 33);
			this.label1.TabIndex = 5;
			this.label1.Text = " 5 in a line to win ";
			// 
			// txtPlayerName
			// 
			this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlayerName.Location = new System.Drawing.Point(163, 39);
			this.txtPlayerName.Name = "txtPlayerName";
			this.txtPlayerName.Size = new System.Drawing.Size(172, 22);
			this.txtPlayerName.TabIndex = 0;
			// 
			// pctbMark
			// 
			this.pctbMark.BackColor = System.Drawing.SystemColors.Control;
			this.pctbMark.Location = new System.Drawing.Point(3, 3);
			this.pctbMark.Name = "pctbMark";
			this.pctbMark.Size = new System.Drawing.Size(154, 138);
			this.pctbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctbMark.TabIndex = 2;
			this.pctbMark.TabStop = false;
			// 
			// tmCoolDown
			// 
			this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(999, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.undoToolStripMenuItem.Text = "Undo";
			this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(999, 612);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlChessBroad);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Game Co Caro";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlChessBroad;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pctbAvatar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pctbMark;
		private System.Windows.Forms.ProgressBar prcbCoolDown;
		private System.Windows.Forms.TextBox txtPlayerName;
		private System.Windows.Forms.Timer tmCoolDown;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
	}
}

