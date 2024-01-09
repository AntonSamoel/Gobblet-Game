namespace Gobblet_Game
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void pvpRb_CheckedChanged(object sender, EventArgs e)
		{
			difficultyPlayerVsComputerCb.Enabled = false;
			//difficultyPlayerVsComputerCb.BackColor = Color.Black;
			difficultyC1Cb.Enabled = false;
			//difficultyC1Cb.BackColor = Color.Black;
			difficultyC2Cb.Enabled = false;
			//difficultyC2Cb.BackColor = Color.Black;
		}

		private void pvcRb_CheckedChanged(object sender, EventArgs e)
		{
			difficultyPlayerVsComputerCb.Enabled = true;
			difficultyC1Cb.Enabled = false;
			difficultyC2Cb.Enabled = false;

		}

		private void cvcRb_CheckedChanged(object sender, EventArgs e)
		{
			difficultyPlayerVsComputerCb.Enabled = false;
			difficultyC1Cb.Enabled = true;
			difficultyC2Cb.Enabled = true;

		}

		private void startGamebtn_Click(object sender, EventArgs e)
		{
			if (pvpRb.Checked)
			{
				GameForm gameForm = new (player1Nametb.Text,player2Nametb.Text,false,false);
				gameForm.Show();
			}
			else if (pvcRb.Checked)
			{
                /*if (difficultyPlayerVsComputerCb.SelectedItem is not null)
				{
					int difficultyLevel = difficultyPlayerVsComputerCb.SelectedIndex;
					if(difficultyLevel == 0)
						MessageBox.Show($"Game Mode Player vs Computer  with difficulty: Easy");
					else if(difficultyLevel == 1)
						MessageBox.Show($"Game Mode Player vs Computer  with difficulty: Medium");
					else
						MessageBox.Show($"Game Mode Player vs Computer  with difficulty: Hard");
				}
				else
				{
					MessageBox.Show("Please select a difficulty level");
				}*/
                GameForm gameForm = new(player1Nametb.Text, player2Nametb.Text, false, true);
                gameForm.Show();
            }
			else if (cvcRb.Checked)
			{

				if (difficultyC1Cb.SelectedItem is not null && difficultyC2Cb.SelectedItem is not null)
				{
					int c1DifficultyLevel = difficultyC1Cb.SelectedIndex;
					int c2DifficultyLevel = difficultyC2Cb.SelectedIndex;
					if (c1DifficultyLevel==0 && c2DifficultyLevel==0)
						MessageBox.Show($"Game Mode Computer vs Computer  with difficulty: Easy Easy");
					else if (c1DifficultyLevel == 1 && c2DifficultyLevel==1)
						MessageBox.Show($"Game Mode Player vs Computer  with difficulty: Medium Medium");
					else
						MessageBox.Show($"Game Mode Player vs Computer  with difficulty: Hard Hard");
				}
				else
				{
					MessageBox.Show("Please select a difficulty level for both players");
				}

			}
			else
			{
				MessageBox.Show("Invalid Game Mode");
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			difficultyPlayerVsComputerCb.SelectedIndex = 0;
			difficultyC1Cb.SelectedIndex = 0;
			difficultyC2Cb.SelectedIndex = 0;
		}
	}
}
