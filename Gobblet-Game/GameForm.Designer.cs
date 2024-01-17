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
            stack3 = new PictureBox();
            stack2 = new PictureBox();
            stack1 = new PictureBox();
            p1Name = new Label();
            panel4 = new Panel();
            stack6 = new PictureBox();
            stack5 = new PictureBox();
            stack4 = new PictureBox();
            p2Name = new Label();
            boardPanel = new Panel();
            winningText = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stack3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stack2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stack1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stack6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stack5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stack4).BeginInit();
            boardPanel.SuspendLayout();
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
            newGameBtn.Text = "Restart New Game";
            newGameBtn.UseVisualStyleBackColor = false;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.grunge_checkerboard_texture_background_1048_11685;
            panel2.Controls.Add(stack3);
            panel2.Controls.Add(stack2);
            panel2.Controls.Add(stack1);
            panel2.Controls.Add(p1Name);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 71);
            panel2.Margin = new Padding(6, 5, 6, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 846);
            panel2.TabIndex = 1;
            // 
            // stack3
            // 
            stack3.BackColor = Color.Transparent;
            stack3.Cursor = Cursors.Hand;
            stack3.Image = Properties.Resources.w4;
            stack3.Location = new Point(47, 539);
            stack3.Name = "stack3";
            stack3.Size = new Size(156, 177);
            stack3.SizeMode = PictureBoxSizeMode.Zoom;
            stack3.TabIndex = 5;
            stack3.TabStop = false;
            stack3.Click += stack3_Click;
            // 
            // stack2
            // 
            stack2.BackColor = Color.Transparent;
            stack2.Cursor = Cursors.Hand;
            stack2.Image = Properties.Resources.w4;
            stack2.Location = new Point(47, 317);
            stack2.Name = "stack2";
            stack2.Size = new Size(156, 177);
            stack2.SizeMode = PictureBoxSizeMode.Zoom;
            stack2.TabIndex = 4;
            stack2.TabStop = false;
            stack2.Click += stack2_Click;
            // 
            // stack1
            // 
            stack1.BackColor = Color.Transparent;
            stack1.Cursor = Cursors.Hand;
            stack1.Image = Properties.Resources.w4;
            stack1.Location = new Point(47, 106);
            stack1.Name = "stack1";
            stack1.Size = new Size(156, 177);
            stack1.SizeMode = PictureBoxSizeMode.Zoom;
            stack1.TabIndex = 3;
            stack1.TabStop = false;
            stack1.Click += stack1_Click;
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
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.grunge_checkerboard_texture_background_1048_11685;
            panel4.Controls.Add(stack6);
            panel4.Controls.Add(stack5);
            panel4.Controls.Add(stack4);
            panel4.Controls.Add(p2Name);
            panel4.Dock = DockStyle.Right;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(1080, 71);
            panel4.Margin = new Padding(6, 5, 6, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(268, 846);
            panel4.TabIndex = 3;
            // 
            // stack6
            // 
            stack6.BackColor = Color.Transparent;
            stack6.Cursor = Cursors.Hand;
            stack6.Image = Properties.Resources.b4;
            stack6.Location = new Point(68, 539);
            stack6.Name = "stack6";
            stack6.Size = new Size(156, 177);
            stack6.SizeMode = PictureBoxSizeMode.Zoom;
            stack6.TabIndex = 9;
            stack6.TabStop = false;
            stack6.Click += stack6_Click_1;
            // 
            // stack5
            // 
            stack5.BackColor = Color.Transparent;
            stack5.Cursor = Cursors.Hand;
            stack5.Image = Properties.Resources.b4;
            stack5.Location = new Point(68, 317);
            stack5.Name = "stack5";
            stack5.Size = new Size(156, 177);
            stack5.SizeMode = PictureBoxSizeMode.Zoom;
            stack5.TabIndex = 8;
            stack5.TabStop = false;
            stack5.Click += stack5_Click_1;
            // 
            // stack4
            // 
            stack4.BackColor = Color.Transparent;
            stack4.Cursor = Cursors.Hand;
            stack4.Image = Properties.Resources.b4;
            stack4.Location = new Point(68, 106);
            stack4.Name = "stack4";
            stack4.Size = new Size(156, 177);
            stack4.SizeMode = PictureBoxSizeMode.Zoom;
            stack4.TabIndex = 7;
            stack4.TabStop = false;
            stack4.Click += stack4_Click;
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
            // boardPanel
            // 
            boardPanel.BackColor = SystemColors.Control;
            boardPanel.BackgroundImage = Properties.Resources.grunge_checkerboard_texture_background_1048_11685;
            boardPanel.Controls.Add(winningText);
            boardPanel.Dock = DockStyle.Fill;
            boardPanel.Location = new Point(279, 71);
            boardPanel.Margin = new Padding(6, 5, 6, 5);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new Size(801, 846);
            boardPanel.TabIndex = 2;
            // 
            // winningText
            // 
            winningText.Anchor = AnchorStyles.None;
            winningText.BackColor = Color.White;
            winningText.BorderStyle = BorderStyle.None;
            winningText.Font = new Font("Vineta BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winningText.ForeColor = Color.Green;
            winningText.Location = new Point(3, 317);
            winningText.Multiline = true;
            winningText.Name = "winningText";
            winningText.ReadOnly = true;
            winningText.Size = new Size(795, 60);
            winningText.TabIndex = 0;
            winningText.TextAlign = HorizontalAlignment.Center;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1348, 917);
            Controls.Add(boardPanel);
            Controls.Add(panel4);
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
            ((System.ComponentModel.ISupportInitialize)stack3).EndInit();
            ((System.ComponentModel.ISupportInitialize)stack2).EndInit();
            ((System.ComponentModel.ISupportInitialize)stack1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stack6).EndInit();
            ((System.ComponentModel.ISupportInitialize)stack5).EndInit();
            ((System.ComponentModel.ISupportInitialize)stack4).EndInit();
            boardPanel.ResumeLayout(false);
            boardPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private Panel panel2;
		private Panel panel4;
		private Label p1Name;
		private Label p2Name;
		private PictureBox stack1;
		private PictureBox stack4;
		private PictureBox stack3;
		private PictureBox stack2;
		private PictureBox stack6;
		private PictureBox stack5;
		private Button endGame;
		private Button newGameBtn;
        private Panel boardPanel;
        private TextBox winningText;
    }
}