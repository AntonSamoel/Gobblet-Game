namespace Gobblet_Game
{
	partial class GameForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			panel1 = new Panel();
			endGame = new Button();
			newGameBtn = new Button();
			panel2 = new Panel();
			pictureBox2 = new PictureBox();
			pictureBox1 = new PictureBox();
			pictureBox3 = new PictureBox();
			p1Name = new Label();
			boardPanel = new Panel();
			panel4 = new Panel();
			pictureBox5 = new PictureBox();
			pictureBox4 = new PictureBox();
			pictureBox6 = new PictureBox();
			p2Name = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.BackgroundImage = Properties.Resources.grunge_checkerboard_texture_background_1048_11685;
			panel1.Controls.Add(endGame);
			panel1.Controls.Add(newGameBtn);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(6, 5, 6, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(1348, 71);
			panel1.TabIndex = 0;
			// 
			// endGame
			// 
			endGame.BackColor = Color.FromArgb(64, 64, 64);
			endGame.ForeColor = Color.Moccasin;
			endGame.Location = new Point(264, 12);
			endGame.Name = "endGame";
			endGame.Size = new Size(188, 45);
			endGame.TabIndex = 1;
			endGame.Text = "End Game";
			endGame.UseVisualStyleBackColor = false;
			endGame.Click += endGame_Click;
			// 
			// newGameBtn
			// 
			newGameBtn.BackColor = Color.FromArgb(64, 64, 64);
			newGameBtn.ForeColor = Color.Moccasin;
			newGameBtn.Location = new Point(18, 12);
			newGameBtn.Name = "newGameBtn";
			newGameBtn.Size = new Size(231, 45);
			newGameBtn.TabIndex = 0;
			newGameBtn.Text = "Start New Game";
			newGameBtn.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			panel2.BackgroundImage = Properties.Resources.grunge_checkerboard_texture_background_1048_11685;
			panel2.Controls.Add(pictureBox2);
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(pictureBox3);
			panel2.Controls.Add(p1Name);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(0, 71);
			panel2.Margin = new Padding(6, 5, 6, 5);
			panel2.Name = "panel2";
			panel2.Size = new Size(279, 846);
			panel2.TabIndex = 1;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.Transparent;
			pictureBox2.Image = Properties.Resources.w4;
			pictureBox2.Location = new Point(47, 539);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(156, 177);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 5;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = Properties.Resources.w4;
			pictureBox1.Location = new Point(47, 317);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(156, 177);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.BackColor = Color.Transparent;
			pictureBox3.Image = Properties.Resources.w4;
			pictureBox3.Location = new Point(47, 106);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(156, 177);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 3;
			pictureBox3.TabStop = false;
			// 
			// p1Name
			// 
			p1Name.AutoSize = true;
			p1Name.BackColor = Color.Transparent;
			p1Name.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			p1Name.ForeColor = Color.Moccasin;
			p1Name.Location = new Point(70, 26);
			p1Name.Name = "p1Name";
			p1Name.Size = new Size(135, 38);
			p1Name.TabIndex = 0;
			p1Name.Text = "Player 1";
			// 
			// boardPanel
			// 
			boardPanel.BackColor = SystemColors.Control;
			boardPanel.BackgroundImage = Properties.Resources.grunge_checkerboard_texture_background_1048_11685;
			boardPanel.Dock = DockStyle.Fill;
			boardPanel.Location = new Point(279, 71);
			boardPanel.Margin = new Padding(6, 5, 6, 5);
			boardPanel.Name = "boardPanel";
			boardPanel.Size = new Size(1069, 846);
			boardPanel.TabIndex = 2;
			// 
			// panel4
			// 
			panel4.BackgroundImage = Properties.Resources.grunge_checkerboard_texture_background_1048_11685;
			panel4.Controls.Add(pictureBox5);
			panel4.Controls.Add(pictureBox4);
			panel4.Controls.Add(pictureBox6);
			panel4.Controls.Add(p2Name);
			panel4.Dock = DockStyle.Right;
			panel4.ForeColor = Color.White;
			panel4.Location = new Point(1080, 71);
			panel4.Margin = new Padding(6, 5, 6, 5);
			panel4.Name = "panel4";
			panel4.Size = new Size(268, 846);
			panel4.TabIndex = 3;
			// 
			// pictureBox5
			// 
			pictureBox5.BackColor = Color.Transparent;
			pictureBox5.Image = Properties.Resources.b4;
			pictureBox5.Location = new Point(68, 539);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(156, 177);
			pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 9;
			pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.BackColor = Color.Transparent;
			pictureBox4.Image = Properties.Resources.b4;
			pictureBox4.Location = new Point(68, 317);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(156, 177);
			pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 8;
			pictureBox4.TabStop = false;
			// 
			// pictureBox6
			// 
			pictureBox6.BackColor = Color.Transparent;
			pictureBox6.Image = Properties.Resources.b4;
			pictureBox6.Location = new Point(68, 106);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(156, 177);
			pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox6.TabIndex = 7;
			pictureBox6.TabStop = false;
			// 
			// p2Name
			// 
			p2Name.AutoSize = true;
			p2Name.BackColor = Color.Transparent;
			p2Name.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			p2Name.ForeColor = Color.Moccasin;
			p2Name.Location = new Point(78, 26);
			p2Name.Name = "p2Name";
			p2Name.Size = new Size(135, 38);
			p2Name.TabIndex = 1;
			p2Name.Text = "Player 2";
			// 
			// GameForm
			// 
			AutoScaleDimensions = new SizeF(15F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1348, 917);
			Controls.Add(panel4);
			Controls.Add(boardPanel);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(6, 5, 6, 5);
			MaximizeBox = false;
			Name = "GameForm";
			Text = "Gobblet Game";
			Load += GameForm_Load;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel boardPanel;
		private Panel panel4;
		private Label p1Name;
		private Label p2Name;
		private PictureBox pictureBox3;
		private PictureBox pictureBox6;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private PictureBox pictureBox5;
		private PictureBox pictureBox4;
		private Button endGame;
		private Button newGameBtn;
	}
}