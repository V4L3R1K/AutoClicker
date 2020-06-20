namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClickTimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonStartBasicMode = new System.Windows.Forms.Button();
            this.LabelInterval = new System.Windows.Forms.Label();
            this.NumericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.LabelNumberOfClicks = new System.Windows.Forms.Label();
            this.NumericUpDownNumberOfClicks = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.LabelY = new System.Windows.Forms.Label();
            this.NumericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.LabelX = new System.Windows.Forms.Label();
            this.CheckBoxAboveOtherWindows = new System.Windows.Forms.CheckBox();
            this.ProgressBarClickedTimes = new System.Windows.Forms.ProgressBar();
            this.LabelClickedTimes = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.RadioButtonLMB = new System.Windows.Forms.RadioButton();
            this.RadioButtonRMB = new System.Windows.Forms.RadioButton();
            this.RadioButtonModeBasic = new System.Windows.Forms.RadioButton();
            this.RadioButtonModeProgrammable = new System.Windows.Forms.RadioButton();
            this.RichTextBoxProgram = new System.Windows.Forms.RichTextBox();
            this.GroupBoxBasicMode = new System.Windows.Forms.GroupBox();
            this.GroupBoxProgrammableMode = new System.Windows.Forms.GroupBox();
            this.ButtonStartProgrammableMode = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmableModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberOfClicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.GroupBoxBasicMode.SuspendLayout();
            this.GroupBoxProgrammableMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClickTimer
            // 
            this.ClickTimer.Interval = 1000;
            this.ClickTimer.Tick += new System.EventHandler(this.ClickTimer_Tick);
            // 
            // ButtonStartBasicMode
            // 
            this.ButtonStartBasicMode.Location = new System.Drawing.Point(6, 146);
            this.ButtonStartBasicMode.Name = "ButtonStartBasicMode";
            this.ButtonStartBasicMode.Size = new System.Drawing.Size(292, 23);
            this.ButtonStartBasicMode.TabIndex = 0;
            this.ButtonStartBasicMode.Text = "Start";
            this.ButtonStartBasicMode.UseVisualStyleBackColor = true;
            this.ButtonStartBasicMode.Click += new System.EventHandler(this.ButtonStartBasicMode_Click);
            // 
            // LabelInterval
            // 
            this.LabelInterval.AutoSize = true;
            this.LabelInterval.Location = new System.Drawing.Point(6, 21);
            this.LabelInterval.Name = "LabelInterval";
            this.LabelInterval.Size = new System.Drawing.Size(186, 13);
            this.LabelInterval.TabIndex = 1;
            this.LabelInterval.Text = "Interval in milliseconds between clicks";
            // 
            // NumericUpDownInterval
            // 
            this.NumericUpDownInterval.Location = new System.Drawing.Point(198, 19);
            this.NumericUpDownInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.NumericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownInterval.Name = "NumericUpDownInterval";
            this.NumericUpDownInterval.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownInterval.TabIndex = 2;
            this.NumericUpDownInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownInterval.ValueChanged += new System.EventHandler(this.NumericUpDownInterval_ValueChanged);
            // 
            // LabelNumberOfClicks
            // 
            this.LabelNumberOfClicks.AutoSize = true;
            this.LabelNumberOfClicks.Location = new System.Drawing.Point(6, 47);
            this.LabelNumberOfClicks.Name = "LabelNumberOfClicks";
            this.LabelNumberOfClicks.Size = new System.Drawing.Size(86, 13);
            this.LabelNumberOfClicks.TabIndex = 3;
            this.LabelNumberOfClicks.Text = "Number of clicks";
            // 
            // NumericUpDownNumberOfClicks
            // 
            this.NumericUpDownNumberOfClicks.Location = new System.Drawing.Point(198, 45);
            this.NumericUpDownNumberOfClicks.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownNumberOfClicks.Name = "NumericUpDownNumberOfClicks";
            this.NumericUpDownNumberOfClicks.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownNumberOfClicks.TabIndex = 4;
            this.NumericUpDownNumberOfClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownNumberOfClicks.ValueChanged += new System.EventHandler(this.NumericUpDownNumberOfClicks_ValueChanged);
            // 
            // NumericUpDownY
            // 
            this.NumericUpDownY.Location = new System.Drawing.Point(198, 97);
            this.NumericUpDownY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownY.Name = "NumericUpDownY";
            this.NumericUpDownY.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownY.TabIndex = 8;
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(6, 99);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(88, 13);
            this.LabelY.TabIndex = 7;
            this.LabelY.Text = "Mouse position Y";
            // 
            // NumericUpDownX
            // 
            this.NumericUpDownX.Location = new System.Drawing.Point(198, 71);
            this.NumericUpDownX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownX.Name = "NumericUpDownX";
            this.NumericUpDownX.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownX.TabIndex = 6;
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(6, 73);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(88, 13);
            this.LabelX.TabIndex = 5;
            this.LabelX.Text = "Mouse position X";
            // 
            // CheckBoxAboveOtherWindows
            // 
            this.CheckBoxAboveOtherWindows.AutoSize = true;
            this.CheckBoxAboveOtherWindows.Checked = true;
            this.CheckBoxAboveOtherWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxAboveOtherWindows.Location = new System.Drawing.Point(12, 273);
            this.CheckBoxAboveOtherWindows.Name = "CheckBoxAboveOtherWindows";
            this.CheckBoxAboveOtherWindows.Size = new System.Drawing.Size(128, 17);
            this.CheckBoxAboveOtherWindows.TabIndex = 9;
            this.CheckBoxAboveOtherWindows.Text = "Above other windows";
            this.CheckBoxAboveOtherWindows.UseVisualStyleBackColor = true;
            this.CheckBoxAboveOtherWindows.CheckedChanged += new System.EventHandler(this.CheckBoxAboveOtherWindows_CheckedChanged);
            // 
            // ProgressBarClickedTimes
            // 
            this.ProgressBarClickedTimes.Location = new System.Drawing.Point(6, 175);
            this.ProgressBarClickedTimes.Maximum = 1;
            this.ProgressBarClickedTimes.Name = "ProgressBarClickedTimes";
            this.ProgressBarClickedTimes.Size = new System.Drawing.Size(292, 23);
            this.ProgressBarClickedTimes.TabIndex = 10;
            // 
            // LabelClickedTimes
            // 
            this.LabelClickedTimes.AutoSize = true;
            this.LabelClickedTimes.Location = new System.Drawing.Point(6, 201);
            this.LabelClickedTimes.Name = "LabelClickedTimes";
            this.LabelClickedTimes.Size = new System.Drawing.Size(158, 13);
            this.LabelClickedTimes.TabIndex = 11;
            this.LabelClickedTimes.Text = "Clicked 0 times of 1, 1 clicks left";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip.TabIndex = 12;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // RadioButtonLMB
            // 
            this.RadioButtonLMB.AutoSize = true;
            this.RadioButtonLMB.Checked = true;
            this.RadioButtonLMB.Location = new System.Drawing.Point(6, 123);
            this.RadioButtonLMB.Name = "RadioButtonLMB";
            this.RadioButtonLMB.Size = new System.Drawing.Size(110, 17);
            this.RadioButtonLMB.TabIndex = 13;
            this.RadioButtonLMB.TabStop = true;
            this.RadioButtonLMB.Text = "Left mouse button";
            this.RadioButtonLMB.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRMB
            // 
            this.RadioButtonRMB.AutoSize = true;
            this.RadioButtonRMB.Location = new System.Drawing.Point(122, 123);
            this.RadioButtonRMB.Name = "RadioButtonRMB";
            this.RadioButtonRMB.Size = new System.Drawing.Size(117, 17);
            this.RadioButtonRMB.TabIndex = 14;
            this.RadioButtonRMB.Text = "Right mouse button";
            this.RadioButtonRMB.UseVisualStyleBackColor = true;
            // 
            // RadioButtonModeBasic
            // 
            this.RadioButtonModeBasic.AutoSize = true;
            this.RadioButtonModeBasic.Checked = true;
            this.RadioButtonModeBasic.Location = new System.Drawing.Point(12, 27);
            this.RadioButtonModeBasic.Name = "RadioButtonModeBasic";
            this.RadioButtonModeBasic.Size = new System.Drawing.Size(80, 17);
            this.RadioButtonModeBasic.TabIndex = 15;
            this.RadioButtonModeBasic.TabStop = true;
            this.RadioButtonModeBasic.Text = "Basic mode";
            this.RadioButtonModeBasic.UseVisualStyleBackColor = true;
            this.RadioButtonModeBasic.CheckedChanged += new System.EventHandler(this.RadioButtonModeBasic_CheckedChanged);
            // 
            // RadioButtonModeProgrammable
            // 
            this.RadioButtonModeProgrammable.AutoSize = true;
            this.RadioButtonModeProgrammable.Location = new System.Drawing.Point(322, 27);
            this.RadioButtonModeProgrammable.Name = "RadioButtonModeProgrammable";
            this.RadioButtonModeProgrammable.Size = new System.Drawing.Size(121, 17);
            this.RadioButtonModeProgrammable.TabIndex = 16;
            this.RadioButtonModeProgrammable.Text = "Programmable mode";
            this.RadioButtonModeProgrammable.UseVisualStyleBackColor = true;
            this.RadioButtonModeProgrammable.CheckedChanged += new System.EventHandler(this.RadioButtonModeProgrammable_CheckedChanged);
            // 
            // RichTextBoxProgram
            // 
            this.RichTextBoxProgram.AcceptsTab = true;
            this.RichTextBoxProgram.AutoWordSelection = true;
            this.RichTextBoxProgram.BulletIndent = 4;
            this.RichTextBoxProgram.Location = new System.Drawing.Point(6, 19);
            this.RichTextBoxProgram.Name = "RichTextBoxProgram";
            this.RichTextBoxProgram.Size = new System.Drawing.Size(438, 163);
            this.RichTextBoxProgram.TabIndex = 17;
            this.RichTextBoxProgram.Text = "";
            // 
            // GroupBoxBasicMode
            // 
            this.GroupBoxBasicMode.Controls.Add(this.LabelInterval);
            this.GroupBoxBasicMode.Controls.Add(this.NumericUpDownInterval);
            this.GroupBoxBasicMode.Controls.Add(this.LabelNumberOfClicks);
            this.GroupBoxBasicMode.Controls.Add(this.NumericUpDownNumberOfClicks);
            this.GroupBoxBasicMode.Controls.Add(this.LabelClickedTimes);
            this.GroupBoxBasicMode.Controls.Add(this.RadioButtonRMB);
            this.GroupBoxBasicMode.Controls.Add(this.ProgressBarClickedTimes);
            this.GroupBoxBasicMode.Controls.Add(this.LabelX);
            this.GroupBoxBasicMode.Controls.Add(this.ButtonStartBasicMode);
            this.GroupBoxBasicMode.Controls.Add(this.RadioButtonLMB);
            this.GroupBoxBasicMode.Controls.Add(this.NumericUpDownX);
            this.GroupBoxBasicMode.Controls.Add(this.LabelY);
            this.GroupBoxBasicMode.Controls.Add(this.NumericUpDownY);
            this.GroupBoxBasicMode.Location = new System.Drawing.Point(12, 50);
            this.GroupBoxBasicMode.Name = "GroupBoxBasicMode";
            this.GroupBoxBasicMode.Size = new System.Drawing.Size(304, 217);
            this.GroupBoxBasicMode.TabIndex = 18;
            this.GroupBoxBasicMode.TabStop = false;
            // 
            // GroupBoxProgrammableMode
            // 
            this.GroupBoxProgrammableMode.Controls.Add(this.ButtonStartProgrammableMode);
            this.GroupBoxProgrammableMode.Controls.Add(this.RichTextBoxProgram);
            this.GroupBoxProgrammableMode.Enabled = false;
            this.GroupBoxProgrammableMode.Location = new System.Drawing.Point(322, 50);
            this.GroupBoxProgrammableMode.Name = "GroupBoxProgrammableMode";
            this.GroupBoxProgrammableMode.Size = new System.Drawing.Size(450, 217);
            this.GroupBoxProgrammableMode.TabIndex = 19;
            this.GroupBoxProgrammableMode.TabStop = false;
            // 
            // ButtonStartProgrammableMode
            // 
            this.ButtonStartProgrammableMode.Location = new System.Drawing.Point(6, 188);
            this.ButtonStartProgrammableMode.Name = "ButtonStartProgrammableMode";
            this.ButtonStartProgrammableMode.Size = new System.Drawing.Size(438, 23);
            this.ButtonStartProgrammableMode.TabIndex = 15;
            this.ButtonStartProgrammableMode.Text = "Start";
            this.ButtonStartProgrammableMode.UseVisualStyleBackColor = true;
            this.ButtonStartProgrammableMode.Click += new System.EventHandler(this.ButtonStartProgrammableMode_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmableModeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // programmableModeToolStripMenuItem
            // 
            this.programmableModeToolStripMenuItem.Name = "programmableModeToolStripMenuItem";
            this.programmableModeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.programmableModeToolStripMenuItem.Text = "Programmable mode";
            this.programmableModeToolStripMenuItem.Click += new System.EventHandler(this.programmableModeToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Text files|*.txt";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Open file";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text files|.txt";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 302);
            this.Controls.Add(this.GroupBoxProgrammableMode);
            this.Controls.Add(this.GroupBoxBasicMode);
            this.Controls.Add(this.RadioButtonModeProgrammable);
            this.Controls.Add(this.RadioButtonModeBasic);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.CheckBoxAboveOtherWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "AutoClicker";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberOfClicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.GroupBoxBasicMode.ResumeLayout(false);
            this.GroupBoxBasicMode.PerformLayout();
            this.GroupBoxProgrammableMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.Button ButtonStartBasicMode;
        private System.Windows.Forms.Label LabelInterval;
        private System.Windows.Forms.NumericUpDown NumericUpDownInterval;
        private System.Windows.Forms.Label LabelNumberOfClicks;
        private System.Windows.Forms.NumericUpDown NumericUpDownNumberOfClicks;
        private System.Windows.Forms.NumericUpDown NumericUpDownY;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.NumericUpDown NumericUpDownX;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.CheckBox CheckBoxAboveOtherWindows;
        private System.Windows.Forms.ProgressBar ProgressBarClickedTimes;
        private System.Windows.Forms.Label LabelClickedTimes;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.RadioButton RadioButtonLMB;
        private System.Windows.Forms.RadioButton RadioButtonRMB;
        private System.Windows.Forms.RadioButton RadioButtonModeBasic;
        private System.Windows.Forms.RadioButton RadioButtonModeProgrammable;
        private System.Windows.Forms.RichTextBox RichTextBoxProgram;
        private System.Windows.Forms.GroupBox GroupBoxBasicMode;
        private System.Windows.Forms.GroupBox GroupBoxProgrammableMode;
        private System.Windows.Forms.Button ButtonStartProgrammableMode;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmableModeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

