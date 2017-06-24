namespace Portable_Minecraft_Launcher
{
    partial class dev_agreement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_agreement));
            this.pnl_agree = new System.Windows.Forms.Panel();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.btn_disagree = new System.Windows.Forms.Button();
            this.btn_agree = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_main = new System.Windows.Forms.Label();
            this.main_logo = new System.Windows.Forms.PictureBox();
            this.txt_agreement = new System.Windows.Forms.RichTextBox();
            this.pnl_agree.SuspendLayout();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_agree
            // 
            this.pnl_agree.BackColor = System.Drawing.Color.White;
            this.pnl_agree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_agree.Controls.Add(this.lbl_ver);
            this.pnl_agree.Controls.Add(this.btn_disagree);
            this.pnl_agree.Controls.Add(this.btn_agree);
            this.pnl_agree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_agree.Location = new System.Drawing.Point(0, 329);
            this.pnl_agree.Name = "pnl_agree";
            this.pnl_agree.Size = new System.Drawing.Size(504, 67);
            this.pnl_agree.TabIndex = 0;
            // 
            // lbl_ver
            // 
            this.lbl_ver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ver.ForeColor = System.Drawing.Color.Black;
            this.lbl_ver.Location = new System.Drawing.Point(3, 51);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(108, 13);
            this.lbl_ver.TabIndex = 2;
            this.lbl_ver.Text = "You\'re using version: ";
            // 
            // btn_disagree
            // 
            this.btn_disagree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_disagree.BackColor = System.Drawing.Color.White;
            this.btn_disagree.FlatAppearance.BorderSize = 0;
            this.btn_disagree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_disagree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_disagree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disagree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disagree.Location = new System.Drawing.Point(208, 15);
            this.btn_disagree.Name = "btn_disagree";
            this.btn_disagree.Size = new System.Drawing.Size(145, 49);
            this.btn_disagree.TabIndex = 1;
            this.btn_disagree.Text = "Disagree";
            this.btn_disagree.UseVisualStyleBackColor = false;
            this.btn_disagree.Click += new System.EventHandler(this.btn_disagree_Click);
            // 
            // btn_agree
            // 
            this.btn_agree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agree.BackColor = System.Drawing.Color.White;
            this.btn_agree.FlatAppearance.BorderSize = 0;
            this.btn_agree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_agree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_agree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agree.Location = new System.Drawing.Point(359, 15);
            this.btn_agree.Name = "btn_agree";
            this.btn_agree.Size = new System.Drawing.Size(145, 49);
            this.btn_agree.TabIndex = 0;
            this.btn_agree.Text = "Agree";
            this.btn_agree.UseVisualStyleBackColor = false;
            this.btn_agree.Click += new System.EventHandler(this.btn_agree_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.pnl_top.Controls.Add(this.lbl_main);
            this.pnl_top.Controls.Add(this.main_logo);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(504, 72);
            this.pnl_top.TabIndex = 2;
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
            // txt_agreement
            // 
            this.txt_agreement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_agreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_agreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agreement.Location = new System.Drawing.Point(0, 72);
            this.txt_agreement.Name = "txt_agreement";
            this.txt_agreement.ReadOnly = true;
            this.txt_agreement.ShortcutsEnabled = false;
            this.txt_agreement.Size = new System.Drawing.Size(504, 257);
            this.txt_agreement.TabIndex = 3;
            this.txt_agreement.Text = resources.GetString("txt_agreement.Text");
            // 
            // dev_agreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portable_Minecraft_Launcher.Properties.Resources.PML_PNL;
            this.ClientSize = new System.Drawing.Size(504, 396);
            this.ControlBox = false;
            this.Controls.Add(this.txt_agreement);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_agree);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dev_agreement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agreement ";
            this.Load += new System.EventHandler(this.dev_agreement_Load);
            this.pnl_agree.ResumeLayout(false);
            this.pnl_agree.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_agree;
        private System.Windows.Forms.Button btn_disagree;
        private System.Windows.Forms.Button btn_agree;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.PictureBox main_logo;
        private System.Windows.Forms.RichTextBox txt_agreement;
    }
}