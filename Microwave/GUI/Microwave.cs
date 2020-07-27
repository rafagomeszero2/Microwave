using Microwave.Entities;
using Microwave.Exceptions;
using Microwave.IO;
using System;
using System.IO;
using System.Windows.Forms;

namespace Microwave
{
    public partial class Microwave : Form
    {
        private Plate plate;
        private int min;
        private int sec;
        private int displayTimerCount;
        private bool timerPause;

        public Microwave()
        {
            InitializeComponent();
            DefaultPrograms.WritePrograms();
            ReadPrograms();
            ClearFields();
        }

        private void lbxDisplayPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxDisplayPrograms.SelectedIndex != -1)
            {
                var obj = lbxDisplayPrograms.SelectedItem as DefaultPrograms;

                txbTimer.Text = obj.ProgramTimer.ToString();
                txbPower.Text = obj.ProgramPower.ToString();
                txbFood.Text = obj.ProgramName;
                txbInstruction.Text = obj.ProgramInstruction;
                txbChar.Text = obj.ProgramCharacter.ToString();
            }
        }

        private void ReadPrograms()
        {
            lbxDisplayPrograms.DataSource = null;
            lbxDisplayPrograms.DataSource = DefaultPrograms.programsList;
            lbxDisplayPrograms.DisplayMember = "ProgramName";
            lbxDisplayPrograms.ValueMember = "ProgramName";
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            try
            {
                Verifiers.VerifyName(txbFood.Text);
                if (Verifiers.VerifyProgram(txbFood.Text))
                {
                    throw new CustomExceptions("Programa já existente.");
                }
                Verifiers.VerifyTimer(txbTimer.Text);
                int timer = int.Parse(txbTimer.Text);
                int power = Verifiers.VerifyPower(txbPower.Text);
                char character = Verifiers.VerifyChar(txbChar.Text);
                DefaultPrograms.AddCustomProgram(txbFood.Text, txbInstruction.Text, character, power, timer);
                ReadPrograms();
            }
            catch (CustomExceptions errorMessage)
            {
                MessageBox.Show(errorMessage.Message);
            }
            catch (FormatException errorMessage)
            {
                MessageBox.Show(errorMessage.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Verifiers.VerifyName(txbFood.Text);
                string path = "";
                string food = txbFood.Text;
                if (FileIO.IsFile(txbFood.Text))
                {
                    path = txbFood.Text;
                    food = FileIO.ReadFile(path);
                }

                Verifiers.VerifyTimer(txbTimer.Text);
                int timer = int.Parse(txbTimer.Text);

                int power = Verifiers.VerifyPower(txbPower.Text);

                char character = Verifiers.VerifyChar(txbChar.Text);

                plate = new Plate(food, timer, power, character);

                if (path != "")
                {
                    displayTimerCount = plate.Timer;
                    timerDisplay.Start();
                    plate.StartCook(path);
                }
                else
                {
                    displayTimerCount = plate.Timer;
                    timerDisplay.Start();
                    plate.StartCook();
                }
            }
            catch (CustomExceptions errorMessage)
            {
                MessageBox.Show(errorMessage.Message);
            }
            catch (FormatException errorMessage)
            {
                MessageBox.Show(errorMessage.Message);
            }
            catch (IOException errorMessage)
            {
                MessageBox.Show(errorMessage.Message);
            }
            catch (Exception errorMessage)
            {
                MessageBox.Show(errorMessage.Message);
            }

        }

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            if (displayTimerCount > 60)
            {
                min = 1;
                sec = displayTimerCount % 60;
            }
            else
            {
                min = 0;
                sec = displayTimerCount;
            }

            lbDisplay.Text = $"{min}:{sec}";

            if (min == 0 && sec == 0)
            {
                lbResult.Text = plate.Food;
                ClearFields();
                timerDisplay.Stop();
                MessageBox.Show("Finalizado!");
            }
            displayTimerCount--;
        }

        private void btnFastStart_Click(object sender, EventArgs e)
        {
            txbPower.Text = DefaultConfiguration.FAST_POWER.ToString();
            txbTimer.Text = DefaultConfiguration.FAST_TIMER.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timerPause == true)
            {
                timerDisplay.Start();
                timerPause = false;
            }
            else
            {
                timerDisplay.Stop();
                timerPause = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerDisplay.Stop();
            displayTimerCount = 0;
            ClearFields();
            timerPause = false;
        }

        private void ClearFields()
        {
            txbTimer.Text = "";
            txbPower.Text = "";
            txbChar.Text = ".";
            txbInstruction.Text = "";
            txbFood.Text = "";
            lbxDisplayPrograms.ClearSelected();
            lbDisplay.Text = "0:00";
        }
    }
}
