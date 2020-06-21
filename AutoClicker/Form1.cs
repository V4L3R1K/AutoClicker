using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern long SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dsFlags, int dx, int dy, int cButtons, int dsExtraInfo);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            if (Program.counter < NumericUpDownNumberOfClicks.Value)
            {
                SetCursorPos(Convert.ToInt32(NumericUpDownX.Value), Convert.ToInt32(NumericUpDownY.Value));
                if (RadioButtonLMB.Checked)
                {
                    mouse_event(0x02, 0, 0, 0, 0);
                    mouse_event(0x04, 0, 0, 0, 0);
                }
                else if (RadioButtonRMB.Checked)
                {
                    mouse_event(0x08, 0, 0, 0, 0);
                    mouse_event(0x10, 0, 0, 0, 0);
                }
                Program.counter++;
            }
            else
            {
                ClickTimer.Enabled = false;
                ButtonStartBasicMode.Text = "Start";
                NumericUpDownInterval.Enabled = true;
                NumericUpDownNumberOfClicks.Enabled = true;
                NumericUpDownX.Enabled = true;
                NumericUpDownY.Enabled = true;
                Program.counter = 0;
            }
            LabelClickedTimes.Text = "Clicked " + Program.counter + " times of " + NumericUpDownNumberOfClicks.Value + ", " + (NumericUpDownNumberOfClicks.Value - Program.counter) + " clicks left";
            ProgressBarClickedTimes.Value = Program.counter;
        }

        private void NumericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            ClickTimer.Interval = Convert.ToInt32(NumericUpDownInterval.Value);
            LabelClickedTimes.Text = "Clicked " + Program.counter + " times of " + NumericUpDownNumberOfClicks.Value + ", " + (NumericUpDownNumberOfClicks.Value - Program.counter) + " clicks left";
        }

        private void ButtonStartBasicMode_Click(object sender, EventArgs e)
        {
            if (RadioButtonModeBasic.Checked)
            {
                if (ButtonStartBasicMode.Text == "Start")
                {
                    NumericUpDownInterval.Enabled = false;
                    NumericUpDownNumberOfClicks.Enabled = false;
                    NumericUpDownX.Enabled = false;
                    NumericUpDownY.Enabled = false;
                    ButtonStartBasicMode.Text = "Stop";
                    ClickTimer.Enabled = true;
                }
                else if (ButtonStartBasicMode.Text == "Stop")
                {
                    ClickTimer.Enabled = false;
                    ButtonStartBasicMode.Text = "Start";
                    NumericUpDownInterval.Enabled = true;
                    NumericUpDownNumberOfClicks.Enabled = true;
                    NumericUpDownX.Enabled = true;
                    NumericUpDownY.Enabled = true;
                    Program.counter = 0;
                }
            }
        }

        private void CheckBoxAboveOtherWindows_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = CheckBoxAboveOtherWindows.Checked;
        }

        private void NumericUpDownNumberOfClicks_ValueChanged(object sender, EventArgs e)
        {
            LabelClickedTimes.Text = "Clicked " + Program.counter + " times of " + NumericUpDownNumberOfClicks.Value + ", " + (NumericUpDownNumberOfClicks.Value - Program.counter) + " clicks left";
            ProgressBarClickedTimes.Maximum = Convert.ToInt32(NumericUpDownNumberOfClicks.Value);
        }

        private void ButtonStartProgrammableMode_Click(object sender, EventArgs e)
        {
            Do(string.Join("",string.Join("",string.Join("", RichTextBoxProgram.Text.Split('\n')).Split(' ')).Split('\t')));
        }

        private void RadioButtonModeBasic_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonModeBasic.Checked)
            {
                GroupBoxBasicMode.Enabled = true;
            }
            else
            {
                GroupBoxBasicMode.Enabled = false;
            }
        }

        private void RadioButtonModeProgrammable_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonModeProgrammable.Checked)
            {
                GroupBoxProgrammableMode.Enabled = true;
            }
            else
            {
                GroupBoxProgrammableMode.Enabled = false;
            }
        }

        private void Do(string inputString)
        {
            bool alive = true;
            while (alive)
            {
                if (inputString == string.Empty)
                {
                    alive = false;
                }
                if (inputString.StartsWith("x("))
                {
                    int closeIndex = 0;
                    for (int i = 0; i < Convert.ToInt32(inputString.Split('(')[1].Split(')')[0]); i++)
                    {
                        string outputString = "";
                        closeIndex = 0;
                        int openNum = 0;
                        int closeNum = 0;
                        for(int j = inputString.IndexOf("{") + 1; j < inputString.Length; j++)
                        {
                            if (inputString[j] == '{')
                            {
                                openNum++;
                            }
                            if (inputString[j] == '}')
                            {
                                closeNum++;
                            }
                            if (openNum - closeNum == -1)
                            {
                                closeIndex = j;
                                break;
                            }
                        }
                        for (int j = inputString.IndexOf("{") + 1; j < closeIndex; j++)
                        {
                            outputString += inputString[j];
                        }
                        RichTextBoxProgram.AppendText(outputString);
                        Do(outputString);
                    }
                    inputString = inputString.Remove(0, closeIndex + 1);
                }
                if (inputString.StartsWith("click("))
                {
                    SetCursorPos(Convert.ToInt32(inputString.Split('(')[1].Split(')')[0].Split(',')[1]), Convert.ToInt32(inputString.Split('(')[1].Split(')')[0].Split(',')[2]));
                    if (inputString.Split('(')[1].Split(')')[0].Split(',')[0] == "lmb")
                    {
                        mouse_event(0x02, 0, 0, 0, 0);
                        mouse_event(0x04, 0, 0, 0, 0);
                    }
                    else if(inputString.Split('(')[1].Split(')')[0].Split(',')[0] == "rmb")
                    {
                        mouse_event(0x08, 0, 0, 0, 0);
                        mouse_event(0x10, 0, 0, 0, 0);
                    }
                    inputString = inputString.Remove(0, inputString.IndexOf(";") + 1);
                }
            }      
        }

        private void programmableModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
                {
                    RichTextBoxProgram.Text = reader.ReadToEnd();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile()))
                {
                    writer.Write(RichTextBoxProgram.Text);
                }
            }
        }
    }
}