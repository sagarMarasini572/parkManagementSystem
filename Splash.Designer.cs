
namespace ParkManagementSystem
{
    partial class Splash
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.VersioLbl = new System.Windows.Forms.Label();
            this.ParkPictureBox = new System.Windows.Forms.PictureBox();
            this.MyProgress = new System.Windows.Forms.ProgressBar();
            this.MyProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.Progress = new System.Windows.Forms.Label();
            this.LoadingLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ParkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(62, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(410, 29);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Holiday Park Management System";
            // 
            // VersioLbl
            // 
            this.VersioLbl.AutoSize = true;
            this.VersioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersioLbl.ForeColor = System.Drawing.Color.White;
            this.VersioLbl.Location = new System.Drawing.Point(193, 53);
            this.VersioLbl.Name = "VersioLbl";
            this.VersioLbl.Size = new System.Drawing.Size(105, 24);
            this.VersioLbl.TabIndex = 1;
            this.VersioLbl.Text = "Version 1.0";
            this.VersioLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ParkPictureBox
            // 
            this.ParkPictureBox.Image = global::ParkManagementSystem.Properties.Resources.park;
            this.ParkPictureBox.Location = new System.Drawing.Point(166, 90);
            this.ParkPictureBox.Name = "ParkPictureBox";
            this.ParkPictureBox.Size = new System.Drawing.Size(156, 114);
            this.ParkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ParkPictureBox.TabIndex = 2;
            this.ParkPictureBox.TabStop = false;
            // 
            // MyProgress
            // 
            this.MyProgress.Location = new System.Drawing.Point(0, 235);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.Size = new System.Drawing.Size(501, 14);
            this.MyProgress.TabIndex = 3;
            // 
            // MyProgressTimer
            // 
            this.MyProgressTimer.Tick += new System.EventHandler(this.MyProgressTimer_Tick);
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress.ForeColor = System.Drawing.Color.White;
            this.Progress.Location = new System.Drawing.Point(271, 207);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(85, 24);
            this.Progress.TabIndex = 4;
            this.Progress.Text = "Progress";
            this.Progress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoadingLbl
            // 
            this.LoadingLbl.AutoSize = true;
            this.LoadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLbl.ForeColor = System.Drawing.Color.White;
            this.LoadingLbl.Location = new System.Drawing.Point(162, 207);
            this.LoadingLbl.Name = "LoadingLbl";
            this.LoadingLbl.Size = new System.Drawing.Size(103, 24);
            this.LoadingLbl.TabIndex = 5;
            this.LoadingLbl.Text = "Loading.....";
            this.LoadingLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(500, 248);
            this.Controls.Add(this.LoadingLbl);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.MyProgress);
            this.Controls.Add(this.ParkPictureBox);
            this.Controls.Add(this.VersioLbl);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label VersioLbl;
        private System.Windows.Forms.PictureBox ParkPictureBox;
        private System.Windows.Forms.ProgressBar MyProgress;
        private System.Windows.Forms.Timer MyProgressTimer;
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.Label LoadingLbl;
    }
}