
namespace ParkManagementSystem
{
    partial class ViewWeeklyReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.WeeklyReportDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ChooseDayLbl = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.WeeklyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeeklyReportLbl = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.LogoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DailyReportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TicketsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.holidayTicketBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyChart)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.guna2CustomGradientPanel2;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel2.Controls.Add(this.chart1);
            this.guna2CustomGradientPanel2.Controls.Add(this.sortBox);
            this.guna2CustomGradientPanel2.Controls.Add(this.WeeklyReportDatePicker);
            this.guna2CustomGradientPanel2.Controls.Add(this.ChooseDayLbl);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2VSeparator1);
            this.guna2CustomGradientPanel2.Controls.Add(this.WeeklyChart);
            this.guna2CustomGradientPanel2.Controls.Add(this.WeeklyReportLbl);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(218, 12);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(909, 429);
            this.guna2CustomGradientPanel2.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(39, 98);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Income";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(448, 292);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // sortBox
            // 
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Total Visitors",
            "Total Earning"});
            this.sortBox.Location = new System.Drawing.Point(381, 59);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(106, 21);
            this.sortBox.TabIndex = 8;
            this.sortBox.Text = "Sort By";
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.sortBox_SelectedIndexChanged);
            // 
            // WeeklyReportDatePicker
            // 
            this.WeeklyReportDatePicker.Checked = true;
            this.WeeklyReportDatePicker.CheckedState.Parent = this.WeeklyReportDatePicker;
            this.WeeklyReportDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WeeklyReportDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.WeeklyReportDatePicker.HoverState.Parent = this.WeeklyReportDatePicker;
            this.WeeklyReportDatePicker.Location = new System.Drawing.Point(149, 57);
            this.WeeklyReportDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.WeeklyReportDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.WeeklyReportDatePicker.Name = "WeeklyReportDatePicker";
            this.WeeklyReportDatePicker.ShadowDecoration.Parent = this.WeeklyReportDatePicker;
            this.WeeklyReportDatePicker.Size = new System.Drawing.Size(200, 24);
            this.WeeklyReportDatePicker.TabIndex = 7;
            this.WeeklyReportDatePicker.Value = new System.DateTime(2021, 12, 19, 18, 10, 6, 259);
            this.WeeklyReportDatePicker.ValueChanged += new System.EventHandler(this.DailyReportDatePicker_ValueChanged);
            // 
            // ChooseDayLbl
            // 
            this.ChooseDayLbl.AutoSize = true;
            this.ChooseDayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDayLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ChooseDayLbl.Location = new System.Drawing.Point(20, 57);
            this.ChooseDayLbl.Name = "ChooseDayLbl";
            this.ChooseDayLbl.Size = new System.Drawing.Size(123, 24);
            this.ChooseDayLbl.TabIndex = 6;
            this.ChooseDayLbl.Text = "Choose Day";
            this.ChooseDayLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2VSeparator1.FillThickness = 4;
            this.guna2VSeparator1.Location = new System.Drawing.Point(493, 59);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 357);
            this.guna2VSeparator1.TabIndex = 5;
            // 
            // WeeklyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.WeeklyChart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.WeeklyChart.Legends.Add(legend2);
            this.WeeklyChart.Location = new System.Drawing.Point(512, 91);
            this.WeeklyChart.Name = "WeeklyChart";
            this.WeeklyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Visitors Count";
            this.WeeklyChart.Series.Add(series2);
            this.WeeklyChart.Size = new System.Drawing.Size(385, 325);
            this.WeeklyChart.TabIndex = 4;
            this.WeeklyChart.Text = "chart1";
            // 
            // WeeklyReportLbl
            // 
            this.WeeklyReportLbl.AutoSize = true;
            this.WeeklyReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyReportLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.WeeklyReportLbl.Location = new System.Drawing.Point(350, 17);
            this.WeeklyReportLbl.Name = "WeeklyReportLbl";
            this.WeeklyReportLbl.Size = new System.Drawing.Size(184, 29);
            this.WeeklyReportLbl.TabIndex = 0;
            this.WeeklyReportLbl.Text = "Weekly Report";
            this.WeeklyReportLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.holidayTicketBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.ExitBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.LogoutBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.DailyReportBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.TicketsBtn);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(210, 429);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.DisabledState.Parent = this.ExitBtn;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(0, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(37, 34);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.LogoutBtn.BorderRadius = 15;
            this.LogoutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LogoutBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.LogoutBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.LogoutBtn.CheckedState.Parent = this.LogoutBtn;
            this.LogoutBtn.CustomImages.Parent = this.LogoutBtn;
            this.LogoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutBtn.DisabledState.Parent = this.LogoutBtn;
            this.LogoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.HoverState.Parent = this.LogoutBtn;
            this.LogoutBtn.Location = new System.Drawing.Point(28, 371);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.ShadowDecoration.Parent = this.LogoutBtn;
            this.LogoutBtn.Size = new System.Drawing.Size(192, 45);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // DailyReportBtn
            // 
            this.DailyReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.DailyReportBtn.BorderRadius = 15;
            this.DailyReportBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DailyReportBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.DailyReportBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.DailyReportBtn.CheckedState.Parent = this.DailyReportBtn;
            this.DailyReportBtn.CustomImages.Parent = this.DailyReportBtn;
            this.DailyReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DailyReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DailyReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DailyReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DailyReportBtn.DisabledState.Parent = this.DailyReportBtn;
            this.DailyReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.DailyReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyReportBtn.ForeColor = System.Drawing.Color.White;
            this.DailyReportBtn.HoverState.Parent = this.DailyReportBtn;
            this.DailyReportBtn.Location = new System.Drawing.Point(28, 217);
            this.DailyReportBtn.Name = "DailyReportBtn";
            this.DailyReportBtn.ShadowDecoration.Parent = this.DailyReportBtn;
            this.DailyReportBtn.Size = new System.Drawing.Size(192, 45);
            this.DailyReportBtn.TabIndex = 4;
            this.DailyReportBtn.Text = "Daily Report";
            this.DailyReportBtn.Click += new System.EventHandler(this.DailyReportBtn_Click);
            // 
            // TicketsBtn
            // 
            this.TicketsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.TicketsBtn.BorderRadius = 15;
            this.TicketsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TicketsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.TicketsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.TicketsBtn.CheckedState.Parent = this.TicketsBtn;
            this.TicketsBtn.CustomImages.Parent = this.TicketsBtn;
            this.TicketsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TicketsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TicketsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TicketsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TicketsBtn.DisabledState.Parent = this.TicketsBtn;
            this.TicketsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.TicketsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketsBtn.ForeColor = System.Drawing.Color.White;
            this.TicketsBtn.HoverState.Parent = this.TicketsBtn;
            this.TicketsBtn.Location = new System.Drawing.Point(28, 73);
            this.TicketsBtn.Name = "TicketsBtn";
            this.TicketsBtn.ShadowDecoration.Parent = this.TicketsBtn;
            this.TicketsBtn.Size = new System.Drawing.Size(192, 45);
            this.TicketsBtn.TabIndex = 3;
            this.TicketsBtn.Text = "Normal Ticket";
            this.TicketsBtn.Click += new System.EventHandler(this.TicketsBtn_Click);
            // 
            // holidayTicketBtn
            // 
            this.holidayTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.holidayTicketBtn.BorderRadius = 15;
            this.holidayTicketBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.holidayTicketBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.holidayTicketBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.holidayTicketBtn.CheckedState.Parent = this.holidayTicketBtn;
            this.holidayTicketBtn.CustomImages.Parent = this.holidayTicketBtn;
            this.holidayTicketBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.holidayTicketBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.holidayTicketBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.holidayTicketBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.holidayTicketBtn.DisabledState.Parent = this.holidayTicketBtn;
            this.holidayTicketBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.holidayTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayTicketBtn.ForeColor = System.Drawing.Color.White;
            this.holidayTicketBtn.HoverState.Parent = this.holidayTicketBtn;
            this.holidayTicketBtn.Location = new System.Drawing.Point(28, 144);
            this.holidayTicketBtn.Name = "holidayTicketBtn";
            this.holidayTicketBtn.ShadowDecoration.Parent = this.holidayTicketBtn;
            this.holidayTicketBtn.Size = new System.Drawing.Size(192, 45);
            this.holidayTicketBtn.TabIndex = 7;
            this.holidayTicketBtn.Text = "Holiday Ticket";
            this.holidayTicketBtn.Click += new System.EventHandler(this.holidayTicketBtn_Click);
            // 
            // ViewWeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1139, 455);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewWeeklyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeeklyReport";
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyChart)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton ExitBtn;
        private Guna.UI2.WinForms.Guna2Button LogoutBtn;
        private Guna.UI2.WinForms.Guna2Button DailyReportBtn;
        private Guna.UI2.WinForms.Guna2Button TicketsBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label WeeklyReportLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeeklyChart;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2DateTimePicker WeeklyReportDatePicker;
        private System.Windows.Forms.Label ChooseDayLbl;
        private System.Windows.Forms.ComboBox sortBox;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Button holidayTicketBtn;
    }
}