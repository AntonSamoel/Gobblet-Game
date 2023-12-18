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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			gameModeGroupBox = new GroupBox();
			difficultyC2Cb = new ComboBox();
			difficultyC1Cb = new ComboBox();
			cvcRb = new RadioButton();
			difficultyPlayerVsComputerCb = new ComboBox();
			pvcRb = new RadioButton();
			pvpRb = new RadioButton();
			label1 = new Label();
			startGamebtn = new Button();
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
			gameModeGroupBox.ForeColor = Color.Aqua;
			gameModeGroupBox.Location = new Point(60, 112);
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
			difficultyC2Cb.BackColor = Color.FromArgb(0, 0, 64);
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
			difficultyC1Cb.BackColor = Color.FromArgb(0, 0, 64);
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
			difficultyPlayerVsComputerCb.BackColor = Color.FromArgb(0, 0, 64);
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
			label1.ForeColor = Color.Aqua;
			label1.Location = new Point(282, 39);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new Size(269, 45);
			label1.TabIndex = 1;
			label1.Text = "Gobblet Game";
			// 
			// startGamebtn
			// 
			startGamebtn.BackColor = Color.Black;
			startGamebtn.Location = new Point(581, 635);
			startGamebtn.Name = "startGamebtn";
			startGamebtn.Size = new Size(224, 62);
			startGamebtn.TabIndex = 2;
			startGamebtn.Text = "Start Game";
			startGamebtn.UseVisualStyleBackColor = false;
			startGamebtn.Click += startGamebtn_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(16F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(866, 746);
			Controls.Add(startGamebtn);
			Controls.Add(label1);
			Controls.Add(gameModeGroupBox);
			Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ForeColor = Color.Aquamarine;
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
	}
}
