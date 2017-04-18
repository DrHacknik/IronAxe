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
            this.txt_agreement = new System.Windows.Forms.RichTextBox();
            this.pnl_agree.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_agree
            // 
            this.pnl_agree.BackColor = System.Drawing.Color.Transparent;
            this.pnl_agree.BackgroundImage = global::Portable_Minecraft_Launcher.Properties.Resources.IRONAXE_LOGO;
            this.pnl_agree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_agree.Controls.Add(this.lbl_ver);
            this.pnl_agree.Controls.Add(this.btn_disagree);
            this.pnl_agree.Controls.Add(this.btn_agree);
            this.pnl_agree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_agree.Location = new System.Drawing.Point(0, 187);
            this.pnl_agree.Name = "pnl_agree";
            this.pnl_agree.Size = new System.Drawing.Size(457, 67);
            this.pnl_agree.TabIndex = 0;
            // 
            // lbl_ver
            // 
            this.lbl_ver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ver.ForeColor = System.Drawing.Color.White;
            this.lbl_ver.Location = new System.Drawing.Point(3, 51);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(108, 13);
            this.lbl_ver.TabIndex = 2;
            this.lbl_ver.Text = "You\'re using version: ";
            // 
            // btn_disagree
            // 
            this.btn_disagree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_disagree.BackColor = System.Drawing.Color.Transparent;
            this.btn_disagree.Location = new System.Drawing.Point(298, 41);
            this.btn_disagree.Name = "btn_disagree";
            this.btn_disagree.Size = new System.Drawing.Size(75, 23);
            this.btn_disagree.TabIndex = 1;
            this.btn_disagree.Text = "Disagree";
            this.btn_disagree.UseVisualStyleBackColor = false;
            this.btn_disagree.Click += new System.EventHandler(this.btn_disagree_Click);
            // 
            // btn_agree
            // 
            this.btn_agree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agree.BackColor = System.Drawing.Color.Transparent;
            this.btn_agree.Location = new System.Drawing.Point(379, 41);
            this.btn_agree.Name = "btn_agree";
            this.btn_agree.Size = new System.Drawing.Size(75, 23);
            this.btn_agree.TabIndex = 0;
            this.btn_agree.Text = "Agree";
            this.btn_agree.UseVisualStyleBackColor = false;
            this.btn_agree.Click += new System.EventHandler(this.btn_agree_Click);
            // 
            // txt_agreement
            // 
            this.txt_agreement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_agreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_agreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agreement.Location = new System.Drawing.Point(0, 0);
            this.txt_agreement.Name = "txt_agreement";
            this.txt_agreement.ReadOnly = true;
            this.txt_agreement.ShortcutsEnabled = false;
            this.txt_agreement.Size = new System.Drawing.Size(457, 187);
            this.txt_agreement.TabIndex = 1;
            this.txt_agreement.Text = resources.GetString("txt_agreement.Text");
            // 
            // dev_agreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portable_Minecraft_Launcher.Properties.Resources.PML_PNL;
            this.ClientSize = new System.Drawing.Size(457, 254);
            this.ControlBox = false;
            this.Controls.Add(this.txt_agreement);
            this.Controls.Add(this.pnl_agree);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dev_agreement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agreement ";
            this.Load += new System.EventHandler(this.dev_agreement_Load);
            this.pnl_agree.ResumeLayout(false);
            this.pnl_agree.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_agree;
        private System.Windows.Forms.Button btn_disagree;
        private System.Windows.Forms.Button btn_agree;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.RichTextBox txt_agreement;
    }
}