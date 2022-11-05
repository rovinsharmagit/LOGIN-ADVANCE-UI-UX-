namespace SQL_LOGIN
{
    partial class frmdashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdashboard));
            this.btnfrmdashboardexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfrmdashboardexit
            // 
            this.btnfrmdashboardexit.AutoEllipsis = true;
            this.btnfrmdashboardexit.AutoSize = true;
            this.btnfrmdashboardexit.BackColor = System.Drawing.Color.Teal;
            this.btnfrmdashboardexit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnfrmdashboardexit.FlatAppearance.BorderSize = 0;
            this.btnfrmdashboardexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfrmdashboardexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmdashboardexit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfrmdashboardexit.Location = new System.Drawing.Point(0, 422);
            this.btnfrmdashboardexit.Name = "btnfrmdashboardexit";
            this.btnfrmdashboardexit.Size = new System.Drawing.Size(800, 28);
            this.btnfrmdashboardexit.TabIndex = 0;
            this.btnfrmdashboardexit.Text = "Exit";
            this.btnfrmdashboardexit.UseVisualStyleBackColor = false;
            this.btnfrmdashboardexit.Click += new System.EventHandler(this.btnfrmdashboardexit_Click);
            // 
            // frmdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfrmdashboardexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfrmdashboardexit;
    }
}