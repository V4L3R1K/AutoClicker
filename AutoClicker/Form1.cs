﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

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
                ButtonStart.Text = "Start";
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

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (ButtonStart.Text == "Start")
            {
                NumericUpDownInterval.Enabled = false;
                NumericUpDownNumberOfClicks.Enabled = false;
                NumericUpDownX.Enabled = false;
                NumericUpDownY.Enabled = false;
                ButtonStart.Text = "Stop";
                ClickTimer.Enabled = true;
            }
            else if (ButtonStart.Text == "Stop")
            {
                ClickTimer.Enabled = false;
                ButtonStart.Text = "Start";
                NumericUpDownInterval.Enabled = true;
                NumericUpDownNumberOfClicks.Enabled = true;
                NumericUpDownX.Enabled = true;
                NumericUpDownY.Enabled = true;
                Program.counter = 0;
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
    }
}