namespace Portable_Minecraft_Launcher
{
    partial class dev_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_settings));
            this.btn_save = new System.Windows.Forms.Button();
            this.chck_def_prof_st = new System.Windows.Forms.CheckBox();
            this.lbl_def_prof_st = new System.Windows.Forms.Label();
            this.chck_upd = new System.Windows.Forms.CheckBox();
            this.btn_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_reset_cache = new System.Windows.Forms.Button();
            this.chck_def_pof_st_java = new System.Windows.Forms.CheckBox();
            this.chck_overide_bit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(117, 184);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(92, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save and Close ";
            this.btn_tooltip.SetToolTip(this.btn_save, "Save the settings and close the menu.");
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chck_def_prof_st
            // 
            this.chck_def_prof_st.AutoSize = true;
            this.chck_def_prof_st.Location = new System.Drawing.Point(12, 12);
            this.chck_def_prof_st.Name = "chck_def_prof_st";
            this.chck_def_prof_st.Size = new System.Drawing.Size(178, 17);
            this.chck_def_prof_st.TabIndex = 1;
            this.chck_def_prof_st.Text = "Start Default Profile upon Start? \r\n";
            this.chck_def_prof_st.UseVisualStyleBackColor = true;
            this.chck_def_prof_st.CheckedChanged += new System.EventHandler(this.chck_def_prof_st_CheckedChanged);
            // 
            // lbl_def_prof_st
            // 
            this.lbl_def_prof_st.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_def_prof_st.Location = new System.Drawing.Point(9, 55);
            this.lbl_def_prof_st.Name = "lbl_def_prof_st";
            this.lbl_def_prof_st.Size = new System.Drawing.Size(190, 59);
            this.lbl_def_prof_st.TabIndex = 2;
            this.lbl_def_prof_st.Text = "This will start the default profile set\r\nwhen launching. Although, you can press\r" +
    "\nCTRL+Q to cancel. ";
            // 
            // chck_upd
            // 
            this.chck_upd.AutoSize = true;
            this.chck_upd.Enabled = false;
            this.chck_upd.Location = new System.Drawing.Point(12, 145);
            this.chck_upd.Name = "chck_upd";
            this.chck_upd.Size = new System.Drawing.Size(184, 17);
            this.chck_upd.TabIndex = 1;
            this.chck_upd.Text = "Automatically Check for updates?";
            this.chck_upd.UseVisualStyleBackColor = true;
            // 
            // btn_tooltip
            // 
            this.btn_tooltip.AutoPopDelay = 15000;
            this.btn_tooltip.InitialDelay = 300;
            this.btn_tooltip.IsBalloon = true;
            this.btn_tooltip.ReshowDelay = 100;
            this.btn_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.btn_tooltip.ToolTipTitle = "Function Information: ";
            // 
            // btn_reset_cache
            // 
            this.btn_reset_cache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset_cache.Location = new System.Drawing.Point(2, 184);
            this.btn_reset_cache.Name = "btn_reset_cache";
            this.btn_reset_cache.Size = new System.Drawing.Size(109, 23);
            this.btn_reset_cache.TabIndex = 3;
            this.btn_reset_cache.Text = "Reset Profile Data";
            this.btn_tooltip.SetToolTip(this.btn_reset_cache, "Resets the Default Profile Data to nothing. WILL NOT REMOVE ANY EXISTING PROFILES" +
        "! ");
            this.btn_reset_cache.UseVisualStyleBackColor = true;
            this.btn_reset_cache.Click += new System.EventHandler(this.btn_reset_cache_Click);
            // 
            // chck_def_pof_st_java
            // 
            this.chck_def_pof_st_java.AutoSize = true;
            this.chck_def_pof_st_java.Enabled = false;
            this.chck_def_pof_st_java.Location = new System.Drawing.Point(21, 35);
            this.chck_def_pof_st_java.Name = "chck_def_pof_st_java";
            this.chck_def_pof_st_java.Size = new System.Drawing.Size(158, 17);
            this.chck_def_pof_st_java.TabIndex = 4;
            this.chck_def_pof_st_java.Text = "Launch with Portable Java?";
            this.chck_def_pof_st_java.UseVisualStyleBackColor = true;
            // 
            // chck_overide_bit
            // 
            this.chck_overide_bit.AutoSize = true;
            this.chck_overide_bit.Location = new System.Drawing.Point(12, 117);
            this.chck_overide_bit.Name = "chck_overide_bit";
            this.chck_overide_bit.Size = new System.Drawing.Size(177, 17);
            this.chck_overide_bit.TabIndex = 1;
            this.chck_overide_bit.Text = "Overide architecture Detection?";
            this.btn_tooltip.SetToolTip(this.chck_overide_bit, resources.GetString("chck_overide_bit.ToolTip"));
            this.chck_overide_bit.UseVisualStyleBackColor = true;
            // 
            // dev_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 208);
            this.ControlBox = false;
            this.Controls.Add(this.chck_def_pof_st_java);
            this.Controls.Add(this.btn_reset_cache);
            this.Controls.Add(this.lbl_def_prof_st);
            this.Controls.Add(this.chck_overide_bit);
            this.Controls.Add(this.chck_upd);
            this.Controls.Add(this.chck_def_prof_st);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dev_settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.dev_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox chck_def_prof_st;
        private System.Windows.Forms.Label lbl_def_prof_st;
        private System.Windows.Forms.CheckBox chck_upd;
        private System.Windows.Forms.ToolTip btn_tooltip;
        private System.Windows.Forms.Button btn_reset_cache;
        private System.Windows.Forms.CheckBox chck_def_pof_st_java;
        private System.Windows.Forms.CheckBox chck_overide_bit;
    }
}