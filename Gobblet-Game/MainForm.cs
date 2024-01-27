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

		private async void startGamebtn_Click(object sender, EventArgs e)
		{
			if (pvpRb.Checked)
			{
				GameForm gameForm = new (player1Nametb.Text,player2Nametb.Text,false,false,0);
				gameForm.Show();
			}
			else if (pvcRb.Checked)
			{
				int depth = 0;
                if (difficultyPlayerVsComputerCb.SelectedItem is not null)
				{
					int difficultyLevel = difficultyPlayerVsComputerCb.SelectedIndex;
					if (difficultyLevel == 0)
						depth = 0;
					else if (difficultyLevel == 1)
						depth = 3;
					else
						depth = 5;
				}
				else
				{
					MessageBox.Show("Please select a difficulty level");
					return;
				}
                GameForm gameForm = new(player1Nametb.Text, player2Nametb.Text, false, true,depth);
                gameForm.Show();
            }
			else if (cvcRb.Checked)
			{
                int depth = 0,depth2 = 0;
                if (difficultyC1Cb.SelectedItem is not null && difficultyC2Cb.SelectedItem is not null)
				{
					int c1DifficultyLevel = difficultyC1Cb.SelectedIndex;
					int c2DifficultyLevel = difficultyC2Cb.SelectedIndex;

					if (c1DifficultyLevel == 0)
						depth = 0;
					else if (c1DifficultyLevel == 1)
						depth = 3;
					else
						depth = 4;
                    if (c2DifficultyLevel == 0)
                        depth2 = 0;
                    else if (c2DifficultyLevel == 1)
                        depth2 = 3;
                    else
                        depth2 = 4;
                }
				else
				{
					MessageBox.Show("Please select a difficulty level for both players");
				}
                GameForm gameForm = new(player1Nametb.Text, player2Nametb.Text, true, true, depth,depth2);
                gameForm.Show();
               // Thread.Sleep(4000);
			   await Task.Delay(3000);
                gameForm.CvsC();
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
