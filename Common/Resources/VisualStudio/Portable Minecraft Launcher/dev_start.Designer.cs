namespace Portable_Minecraft_Launcher
{
    partial class dev_start
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
            this.prg_prog = new System.Windows.Forms.ProgressBar();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_start_tiny = new System.Windows.Forms.Label();
            this.tmr_int = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prg_prog
            // 
            this.prg_prog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prg_prog.Location = new System.Drawing.Point(0, 67);
            this.prg_prog.Name = "prg_prog";
            this.prg_prog.Size = new System.Drawing.Size(319, 10);
            this.prg_prog.TabIndex = 0;
            // 
            // lbl_start
            // 
            this.lbl_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.Location = new System.Drawing.Point(0, 0);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(319, 67);
            this.lbl_start.TabIndex = 1;
            this.lbl_start.Text = "Starting Minecraft";
            this.lbl_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_start_tiny
            // 
            this.lbl_start_tiny.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_start_tiny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start_tiny.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_start_tiny.Location = new System.Drawing.Point(0, 51);
            this.lbl_start_tiny.Name = "lbl_start_tiny";
            this.lbl_start_tiny.Size = new System.Drawing.Size(319, 16);
            this.lbl_start_tiny.TabIndex = 2;
            this.lbl_start_tiny.Text = "When the Progressbar is filled. Press CTRL and Q to cancel.";
            this.lbl_start_tiny.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmr_int
            // 
            this.tmr_int.Enabled = true;
            this.tmr_int.Interval = 45;
            this.tmr_int.Tick += new System.EventHandler(this.tmr_int_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 26);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // dev_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 77);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.lbl_start_tiny);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.prg_prog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dev_start";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dev_start";
            this.TopMost = true;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prg_prog;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_start_tiny;
        private System.Windows.Forms.Timer tmr_int;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}