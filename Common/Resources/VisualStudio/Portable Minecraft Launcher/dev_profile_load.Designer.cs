namespace Portable_Minecraft_Launcher
{
    partial class dev_profile_load
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.txt_prof_name = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.chck_java = new System.Windows.Forms.CheckBox();
            this.chck_default = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(0, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(329, 22);
            this.lbl_header.TabIndex = 5;
            this.lbl_header.Text = "Please type the name of the Profile that you wish to load:\r\n::";
            // 
            // txt_prof_name
            // 
            this.txt_prof_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_prof_name.Location = new System.Drawing.Point(2, 118);
            this.txt_prof_name.MaxLength = 24;
            this.txt_prof_name.Name = "txt_prof_name";
            this.txt_prof_name.Size = new System.Drawing.Size(227, 20);
            this.txt_prof_name.TabIndex = 4;
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.Location = new System.Drawing.Point(242, 116);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // chck_java
            // 
            this.chck_java.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chck_java.AutoSize = true;
            this.chck_java.Location = new System.Drawing.Point(3, 73);
            this.chck_java.Name = "chck_java";
            this.chck_java.Size = new System.Drawing.Size(161, 17);
            this.chck_java.TabIndex = 6;
            this.chck_java.Text = "Launch with Portable Java? ";
            this.chck_java.UseVisualStyleBackColor = true;
            // 
            // chck_default
            // 
            this.chck_default.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chck_default.AutoSize = true;
            this.chck_default.Location = new System.Drawing.Point(3, 95);
            this.chck_default.Name = "chck_default";
            this.chck_default.Size = new System.Drawing.Size(119, 17);
            this.chck_default.TabIndex = 6;
            this.chck_default.Text = "Load Default Profile";
            this.chck_default.UseVisualStyleBackColor = true;
            this.chck_default.CheckStateChanged += new System.EventHandler(this.chck_default_CheckStateChanged);
            // 
            // dev_profile_load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 139);
            this.Controls.Add(this.chck_default);
            this.Controls.Add(this.chck_java);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.txt_prof_name);
            this.Controls.Add(this.btn_load);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dev_profile_load";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Profile ";
            this.Load += new System.EventHandler(this.dev_profile_load_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox txt_prof_name;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.CheckBox chck_java;
        private System.Windows.Forms.CheckBox chck_default;
    }
}