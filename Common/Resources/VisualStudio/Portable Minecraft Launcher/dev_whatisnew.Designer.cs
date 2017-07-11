namespace Portable_Minecraft_Launcher
{
    partial class dev_whatisnew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_whatisnew));
            this.lbl_new = new System.Windows.Forms.Label();
            this.btn_gotcha = new System.Windows.Forms.Button();
            this.pcx_logo = new System.Windows.Forms.PictureBox();
            this.main_logo = new System.Windows.Forms.PictureBox();
            this.lbl_main = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_logo)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_new
            // 
            this.lbl_new.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_new.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_new.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new.Location = new System.Drawing.Point(0, 236);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(565, 358);
            this.lbl_new.TabIndex = 3;
            this.lbl_new.Text = resources.GetString("lbl_new.Text");
            // 
            // btn_gotcha
            // 
            this.btn_gotcha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gotcha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_gotcha.FlatAppearance.BorderSize = 0;
            this.btn_gotcha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_gotcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gotcha.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gotcha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gotcha.Location = new System.Drawing.Point(477, 545);
            this.btn_gotcha.Name = "btn_gotcha";
            this.btn_gotcha.Size = new System.Drawing.Size(88, 49);
            this.btn_gotcha.TabIndex = 9;
            this.btn_gotcha.Text = "Gotcha";
            this.btn_gotcha.UseVisualStyleBackColor = false;
            this.btn_gotcha.Click += new System.EventHandler(this.btn_gotcha_Click);
            // 
            // pcx_logo
            // 
            this.pcx_logo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcx_logo.BackgroundImage = global::Portable_Minecraft_Launcher.Properties.Resources.IRONAXE_LOGO;
            this.pcx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcx_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcx_logo.Location = new System.Drawing.Point(0, 72);
            this.pcx_logo.Name = "pcx_logo";
            this.pcx_logo.Size = new System.Drawing.Size(565, 164);
            this.pcx_logo.TabIndex = 2;
            this.pcx_logo.TabStop = false;
            // 
            // main_logo
            // 
            this.main_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.main_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_logo.BackgroundImage")));
            this.main_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_logo.Location = new System.Drawing.Point(3, 12);
            this.main_logo.Name = "main_logo";
            this.main_logo.Size = new System.Drawing.Size(65, 51);
            this.main_logo.TabIndex = 0;
            this.main_logo.TabStop = false;
            // 
            // lbl_main
            // 
            this.lbl_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_main.AutoSize = true;
            this.lbl_main.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main.ForeColor = System.Drawing.Color.White;
            this.lbl_main.Location = new System.Drawing.Point(74, 29);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(217, 20);
            this.lbl_main.TabIndex = 1;
            this.lbl_main.Text = "IronAxe: What is new in %VER%";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.pnl_top.Controls.Add(this.lbl_main);
            this.pnl_top.Controls.Add(this.main_logo);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(565, 72);
            this.pnl_top.TabIndex = 1;
            // 
            // dev_whatisnew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 594);
            this.ControlBox = false;
            this.Controls.Add(this.btn_gotcha);
            this.Controls.Add(this.lbl_new);
            this.Controls.Add(this.pcx_logo);
            this.Controls.Add(this.pnl_top);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev_whatisnew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dev_whatisnew";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.dev_whatisnew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_logo)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcx_logo;
        private System.Windows.Forms.Label lbl_new;
        private System.Windows.Forms.Button btn_gotcha;
        private System.Windows.Forms.PictureBox main_logo;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Panel pnl_top;
    }
}