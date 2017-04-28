namespace upd_fin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_body = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.dev_upd = new System.Windows.Forms.Timer(this.components);
            this.pic_splash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_body
            // 
            this.lbl_body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_body.BackColor = System.Drawing.Color.White;
            this.lbl_body.Font = new System.Drawing.Font("Segoe UI Light", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_body.Location = new System.Drawing.Point(204, 148);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(270, 61);
            this.lbl_body.TabIndex = 1;
            this.lbl_body.Text = "We\'re updating your IronAxe Experience...";
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_header.BackColor = System.Drawing.Color.White;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Light", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(202, 100);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(215, 46);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Updating IronAxe: ";
            // 
            // dev_upd
            // 
            this.dev_upd.Enabled = true;
            this.dev_upd.Interval = 3000;
            this.dev_upd.Tick += new System.EventHandler(this.dev_upd_Tick);
            // 
            // pic_splash
            // 
            this.pic_splash.BackColor = System.Drawing.Color.White;
            this.pic_splash.BackgroundImage = global::upd_fin.Properties.Resources.IRONAXE_LOGO;
            this.pic_splash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_splash.Location = new System.Drawing.Point(0, 64);
            this.pic_splash.Name = "pic_splash";
            this.pic_splash.Size = new System.Drawing.Size(198, 155);
            this.pic_splash.TabIndex = 0;
            this.pic_splash.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(529, 218);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.pic_splash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IronAxe: Updating...";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_splash;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Timer dev_upd;
    }
}

