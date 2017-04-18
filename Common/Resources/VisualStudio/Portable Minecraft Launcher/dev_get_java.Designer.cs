namespace Portable_Minecraft_Launcher
{
    partial class dev_get_java
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
            this.prog_down = new System.Windows.Forms.ProgressBar();
            this.lbl_status = new System.Windows.Forms.Label();
            this.dev_tmr = new System.Windows.Forms.Timer(this.components);
            this.dev_tmr2 = new System.Windows.Forms.Timer(this.components);
            this.tmr_chck = new System.Windows.Forms.Timer(this.components);
            this.lbl_can = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prog_down
            // 
            this.prog_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prog_down.Location = new System.Drawing.Point(0, 113);
            this.prog_down.Name = "prog_down";
            this.prog_down.Size = new System.Drawing.Size(384, 10);
            this.prog_down.TabIndex = 0;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status.Enabled = false;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(0, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(384, 113);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Downloading...";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_status.Click += new System.EventHandler(this.lbl_status_Click);
            // 
            // dev_tmr
            // 
            this.dev_tmr.Enabled = true;
            this.dev_tmr.Interval = 1000;
            // 
            // dev_tmr2
            // 
            this.dev_tmr2.Interval = 1000;
            this.dev_tmr2.Tick += new System.EventHandler(this.dev_tmr2_Tick);
            // 
            // tmr_chck
            // 
            this.tmr_chck.Enabled = true;
            this.tmr_chck.Interval = 1;
            this.tmr_chck.Tick += new System.EventHandler(this.tmr_chck_Tick);
            // 
            // lbl_can
            // 
            this.lbl_can.AutoSize = true;
            this.lbl_can.BackColor = System.Drawing.Color.Transparent;
            this.lbl_can.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_can.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_can.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_can.ForeColor = System.Drawing.Color.White;
            this.lbl_can.Location = new System.Drawing.Point(0, 100);
            this.lbl_can.Name = "lbl_can";
            this.lbl_can.Size = new System.Drawing.Size(40, 13);
            this.lbl_can.TabIndex = 7;
            this.lbl_can.Text = "Cancel";
            this.lbl_can.Click += new System.EventHandler(this.lbl_can_Click);
            // 
            // dev_get_java
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portable_Minecraft_Launcher.Properties.Resources.PML_PNL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 123);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_can);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.prog_down);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dev_get_java";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dev_get_java";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.dev_get_java_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prog_down;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer dev_tmr;
        private System.Windows.Forms.Timer dev_tmr2;
        private System.Windows.Forms.Timer tmr_chck;
        private System.Windows.Forms.Label lbl_can;
    }
}