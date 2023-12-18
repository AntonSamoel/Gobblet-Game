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
			panel2 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			label1 = new Label();
			label2 = new Label();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(6, 5, 6, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(1348, 102);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(label1);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(0, 102);
			panel2.Margin = new Padding(6, 5, 6, 5);
			panel2.Name = "panel2";
			panel2.Size = new Size(469, 571);
			panel2.TabIndex = 1;
			// 
			// panel3
			// 
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(469, 102);
			panel3.Margin = new Padding(6, 5, 6, 5);
			panel3.Name = "panel3";
			panel3.Size = new Size(879, 571);
			panel3.TabIndex = 2;
			// 
			// panel4
			// 
			panel4.Controls.Add(label2);
			panel4.Dock = DockStyle.Right;
			panel4.Location = new Point(879, 102);
			panel4.Margin = new Padding(6, 5, 6, 5);
			panel4.Name = "panel4";
			panel4.Size = new Size(469, 571);
			panel4.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(85, 26);
			label1.Name = "label1";
			label1.Size = new Size(106, 33);
			label1.TabIndex = 0;
			label1.Text = "Player 1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(182, 26);
			label2.Name = "label2";
			label2.Size = new Size(106, 33);
			label2.TabIndex = 1;
			label2.Text = "Player 2";
			// 
			// GameForm
			// 
			AutoScaleDimensions = new SizeF(15F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1348, 673);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(6, 5, 6, 5);
			Name = "GameForm";
			Text = "GameForm";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
		private Label label1;
		private Label label2;
	}
}