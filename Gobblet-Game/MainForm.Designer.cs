namespace Gobblet_Game
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			gameModeGroupBox = new GroupBox();
			difficultyC2Cb = new ComboBox();
			difficultyC1Cb = new ComboBox();
			cvcRb = new RadioButton();
			difficultyPlayerVsComputerCb = new ComboBox();
			pvcRb = new RadioButton();
			pvpRb = new RadioButton();
			label1 = new Label();
			startGamebtn = new Button();
			player1Nametb = new TextBox();
			label2 = new Label();
			player2Nametb = new TextBox();
			label3 = new Label();
			gameModeGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// gameModeGroupBox
			// 
			gameModeGroupBox.BackColor = Color.Transparent;
			gameModeGroupBox.Controls.Add(difficultyC2Cb);
			gameModeGroupBox.Controls.Add(difficultyC1Cb);
			gameModeGroupBox.Controls.Add(cvcRb);
			gameModeGroupBox.Controls.Add(difficultyPlayerVsComputerCb);
			gameModeGroupBox.Controls.Add(pvcRb);
			gameModeGroupBox.Controls.Add(pvpRb);
			gameModeGroupBox.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			gameModeGroupBox.ForeColor = Color.Moccasin;
			gameModeGroupBox.Location = new Point(60, 59);
			gameModeGroupBox.Margin = new Padding(6, 5, 6, 5);
			gameModeGroupBox.Name = "gameModeGroupBox";
			gameModeGroupBox.Padding = new Padding(6, 5, 6, 5);
			gameModeGroupBox.Size = new Size(745, 501);
			gameModeGroupBox.TabIndex = 0;
			gameModeGroupBox.TabStop = false;
			gameModeGroupBox.Text = "Choose Game Mode:";
			// 
			// difficultyC2Cb
			// 
			difficultyC2Cb.BackColor = Color.FromArgb(64, 64, 64);
			difficultyC2Cb.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			difficultyC2Cb.ForeColor = Color.Transparent;
			difficultyC2Cb.FormattingEnabled = true;
			difficultyC2Cb.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
			difficultyC2Cb.Location = new Point(52, 392);
			difficultyC2Cb.Name = "difficultyC2Cb";
			difficultyC2Cb.Size = new Size(368, 39);
			difficultyC2Cb.TabIndex = 5;
			difficultyC2Cb.Text = "Choose difficulty level for c2";
			// 
			// difficultyC1Cb
			// 
			difficultyC1Cb.BackColor = Color.FromArgb(64, 64, 64);
			difficultyC1Cb.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			difficultyC1Cb.ForeColor = Color.Transparent;
			difficultyC1Cb.FormattingEnabled = true;
			difficultyC1Cb.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
			difficultyC1Cb.Location = new Point(52, 333);
			difficultyC1Cb.Name = "difficultyC1Cb";
			difficultyC1Cb.Size = new Size(368, 39);
			difficultyC1Cb.TabIndex = 4;
			difficultyC1Cb.Text = "Choose difficulty level for c1";
			// 
			// cvcRb
			// 
			cvcRb.AutoSize = true;
			cvcRb.Location = new Point(28, 275);
			cvcRb.Name = "cvcRb";
			cvcRb.Size = new Size(335, 39);
			cvcRb.TabIndex = 3;
			cvcRb.TabStop = true;
			cvcRb.Text = "Computer vs Computer";
			cvcRb.UseVisualStyleBackColor = true;
			cvcRb.CheckedChanged += cvcRb_CheckedChanged;
			// 
			// difficultyPlayerVsComputerCb
			// 
			difficultyPlayerVsComputerCb.BackColor = Color.FromArgb(64, 64, 64);
			difficultyPlayerVsComputerCb.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			difficultyPlayerVsComputerCb.ForeColor = Color.Transparent;
			difficultyPlayerVsComputerCb.FormattingEnabled = true;
			difficultyPlayerVsComputerCb.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
			difficultyPlayerVsComputerCb.Location = new Point(52, 211);
			difficultyPlayerVsComputerCb.Name = "difficultyPlayerVsComputerCb";
			difficultyPlayerVsComputerCb.Size = new Size(321, 39);
			difficultyPlayerVsComputerCb.TabIndex = 2;
			difficultyPlayerVsComputerCb.Text = "Choose difficulty level";
			// 
			// pvcRb
			// 
			pvcRb.AutoSize = true;
			pvcRb.Location = new Point(28, 166);
			pvcRb.Name = "pvcRb";
			pvcRb.Size = new Size(286, 39);
			pvcRb.TabIndex = 1;
			pvcRb.TabStop = true;
			pvcRb.Text = "Player vs Computer";
			pvcRb.UseVisualStyleBackColor = true;
			pvcRb.CheckedChanged += pvcRb_CheckedChanged;
			// 
			// pvpRb
			// 
			pvpRb.AutoSize = true;
			pvpRb.Location = new Point(28, 111);
			pvpRb.Name = "pvpRb";
			pvpRb.Size = new Size(237, 39);
			pvpRb.TabIndex = 0;
			pvpRb.TabStop = true;
			pvpRb.Text = "Player vs Player";
			pvpRb.UseVisualStyleBackColor = true;
			pvpRb.CheckedChanged += pvpRb_CheckedChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Moccasin;
			label1.Location = new Point(278, 9);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new Size(269, 45);
			label1.TabIndex = 1;
			label1.Text = "Gobblet Game";
			// 
			// startGamebtn
			// 
			startGamebtn.BackColor = Color.FromArgb(64, 64, 64);
			startGamebtn.ForeColor = Color.Moccasin;
			startGamebtn.Location = new Point(581, 684);
			startGamebtn.Name = "startGamebtn";
			startGamebtn.Size = new Size(224, 62);
			startGamebtn.TabIndex = 2;
			startGamebtn.Text = "Start Game";
			startGamebtn.UseVisualStyleBackColor = false;
			startGamebtn.Click += startGamebtn_Click;
			// 
			// player1Nametb
			// 
			player1Nametb.BackColor = Color.FromArgb(64, 64, 64);
			player1Nametb.ForeColor = Color.Moccasin;
			player1Nametb.Location = new Point(278, 574);
			player1Nametb.Name = "player1Nametb";
			player1Nametb.Size = new Size(206, 39);
			player1Nametb.TabIndex = 6;
			player1Nametb.Text = "Player 1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = Color.Moccasin;
			label2.Location = new Point(60, 574);
			label2.Name = "label2";
			label2.Size = new Size(196, 32);
			label2.TabIndex = 7;
			label2.Text = "Player 1 Name:";
			// 
			// player2Nametb
			// 
			player2Nametb.BackColor = Color.FromArgb(64, 64, 64);
			player2Nametb.ForeColor = Color.Moccasin;
			player2Nametb.Location = new Point(278, 630);
			player2Nametb.Name = "player2Nametb";
			player2Nametb.Size = new Size(206, 39);
			player2Nametb.TabIndex = 8;
			player2Nametb.Text = "Player 2";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.ForeColor = Color.Moccasin;
			label3.Location = new Point(60, 630);
			label3.Name = "label3";
			label3.Size = new Size(196, 32);
			label3.TabIndex = 9;
			label3.Text = "Player 2 Name:";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(16F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.grunge_checkerboard_texture_background_1048_11685;
			ClientSize = new Size(843, 758);
			Controls.Add(player2Nametb);
			Controls.Add(label3);
			Controls.Add(player1Nametb);
			Controls.Add(label2);
			Controls.Add(startGamebtn);
			Controls.Add(label1);
			Controls.Add(gameModeGroupBox);
			Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ForeColor = Color.White;
			Margin = new Padding(6, 5, 6, 5);
			Name = "MainForm";
			Text = "Form1";
			Load += MainForm_Load;
			gameModeGroupBox.ResumeLayout(false);
			gameModeGroupBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox gameModeGroupBox;
		private Label label1;
		private RadioButton pvpRb;
		private RadioButton pvcRb;
		private ComboBox difficultyPlayerVsComputerCb;
		private ComboBox difficultyC1Cb;
		private RadioButton cvcRb;
		private ComboBox difficultyC2Cb;
		private Button startGamebtn;
		private TextBox player1Nametb;
		private Label label2;
		private TextBox player2Nametb;
		private Label label3;
	}
}
