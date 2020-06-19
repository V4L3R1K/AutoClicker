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
            this.ButtonStart = new System.Windows.Forms.Button();
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
            this.LabelClickedTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberOfClicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).BeginInit();
            this.SuspendLayout();
            // 
            // ClickTimer
            // 
            this.ClickTimer.Interval = 1000;
            this.ClickTimer.Tick += new System.EventHandler(this.ClickTimer_Tick);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(12, 139);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(292, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelInterval
            // 
            this.LabelInterval.AutoSize = true;
            this.LabelInterval.Location = new System.Drawing.Point(12, 14);
            this.LabelInterval.Name = "LabelInterval";
            this.LabelInterval.Size = new System.Drawing.Size(186, 13);
            this.LabelInterval.TabIndex = 1;
            this.LabelInterval.Text = "Interval in milliseconds between clicks";
            // 
            // NumericUpDownInterval
            // 
            this.NumericUpDownInterval.Location = new System.Drawing.Point(204, 12);
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
            this.LabelNumberOfClicks.Location = new System.Drawing.Point(12, 40);
            this.LabelNumberOfClicks.Name = "LabelNumberOfClicks";
            this.LabelNumberOfClicks.Size = new System.Drawing.Size(86, 13);
            this.LabelNumberOfClicks.TabIndex = 3;
            this.LabelNumberOfClicks.Text = "Number of clicks";
            // 
            // NumericUpDownNumberOfClicks
            // 
            this.NumericUpDownNumberOfClicks.Location = new System.Drawing.Point(204, 38);
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
            this.NumericUpDownY.Location = new System.Drawing.Point(204, 90);
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
            this.LabelY.Location = new System.Drawing.Point(12, 92);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(88, 13);
            this.LabelY.TabIndex = 7;
            this.LabelY.Text = "Mouse position Y";
            // 
            // NumericUpDownX
            // 
            this.NumericUpDownX.Location = new System.Drawing.Point(204, 64);
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
            this.LabelX.Location = new System.Drawing.Point(12, 66);
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
            this.CheckBoxAboveOtherWindows.Location = new System.Drawing.Point(12, 116);
            this.CheckBoxAboveOtherWindows.Name = "CheckBoxAboveOtherWindows";
            this.CheckBoxAboveOtherWindows.Size = new System.Drawing.Size(128, 17);
            this.CheckBoxAboveOtherWindows.TabIndex = 9;
            this.CheckBoxAboveOtherWindows.Text = "Above other windows";
            this.CheckBoxAboveOtherWindows.UseVisualStyleBackColor = true;
            this.CheckBoxAboveOtherWindows.CheckedChanged += new System.EventHandler(this.CheckBoxAboveOtherWindows_CheckedChanged);
            // 
            // ProgressBarClickedTimes
            // 
            this.ProgressBarClickedTimes.Location = new System.Drawing.Point(13, 169);
            this.ProgressBarClickedTimes.Maximum = 1;
            this.ProgressBarClickedTimes.Name = "ProgressBarClickedTimes";
            this.ProgressBarClickedTimes.Size = new System.Drawing.Size(291, 23);
            this.ProgressBarClickedTimes.TabIndex = 10;
            // 
            // LabelClickedTimes
            // 
            this.LabelClickedTimes.AutoSize = true;
            this.LabelClickedTimes.Location = new System.Drawing.Point(12, 195);
            this.LabelClickedTimes.Name = "LabelClickedTimes";
            this.LabelClickedTimes.Size = new System.Drawing.Size(158, 13);
            this.LabelClickedTimes.TabIndex = 11;
            this.LabelClickedTimes.Text = "Clicked 0 times of 1, 1 clicks left";
            // 
            // LabelClickedTime
            // 
            this.LabelClickedTime.AutoSize = true;
            this.LabelClickedTime.Location = new System.Drawing.Point(12, 208);
            this.LabelClickedTime.Name = "LabelClickedTime";
            this.LabelClickedTime.Size = new System.Drawing.Size(149, 13);
            this.LabelClickedTime.TabIndex = 12;
            this.LabelClickedTime.Text = "0 seconds of 1, 1 seconds left";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 230);
            this.Controls.Add(this.LabelClickedTime);
            this.Controls.Add(this.LabelClickedTimes);
            this.Controls.Add(this.ProgressBarClickedTimes);
            this.Controls.Add(this.CheckBoxAboveOtherWindows);
            this.Controls.Add(this.NumericUpDownY);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.NumericUpDownX);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.NumericUpDownNumberOfClicks);
            this.Controls.Add(this.LabelNumberOfClicks);
            this.Controls.Add(this.NumericUpDownInterval);
            this.Controls.Add(this.LabelInterval);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "AutoClicker";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberOfClicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.Button ButtonStart;
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
        private System.Windows.Forms.Label LabelClickedTime;
    }
}

