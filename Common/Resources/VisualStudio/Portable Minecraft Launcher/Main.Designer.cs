namespace Portable_Minecraft_Launcher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_profile_create = new System.Windows.Forms.Button();
            this.btn_profile_load = new System.Windows.Forms.Button();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_settings = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_reset.Location = new System.Drawing.Point(25, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(118, 44);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "RESET";
            this.btn_tooltip.SetToolTip(this.btn_reset, "This will Reset all the App\'s settings to their defaults. ");
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_down
            // 
            this.btn_down.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_down.Location = new System.Drawing.Point(25, 81);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(118, 44);
            this.btn_down.TabIndex = 1;
            this.btn_down.Text = "DOWNLOAD_RESOURCES";
            this.btn_tooltip.SetToolTip(this.btn_down, "Download Resources again, if they haven\'t already been downloaded.");
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_profile_create
            // 
            this.btn_profile_create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_profile_create.Location = new System.Drawing.Point(166, 12);
            this.btn_profile_create.Name = "btn_profile_create";
            this.btn_profile_create.Size = new System.Drawing.Size(118, 44);
            this.btn_profile_create.TabIndex = 2;
            this.btn_profile_create.Text = "PROFILE_CREATE";
            this.btn_tooltip.SetToolTip(this.btn_profile_create, "Manage and Create Profiles.");
            this.btn_profile_create.UseVisualStyleBackColor = true;
            this.btn_profile_create.Click += new System.EventHandler(this.btn_profile_create_Click);
            // 
            // btn_profile_load
            // 
            this.btn_profile_load.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_profile_load.Location = new System.Drawing.Point(313, 12);
            this.btn_profile_load.Name = "btn_profile_load";
            this.btn_profile_load.Size = new System.Drawing.Size(118, 44);
            this.btn_profile_load.TabIndex = 3;
            this.btn_profile_load.Text = "PROFILE_LOAD";
            this.btn_tooltip.SetToolTip(this.btn_profile_load, "Load an Profile. ");
            this.btn_profile_load.UseVisualStyleBackColor = true;
            this.btn_profile_load.Click += new System.EventHandler(this.btn_profile_load_Click_1);
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ver.ForeColor = System.Drawing.Color.White;
            this.lbl_ver.Location = new System.Drawing.Point(0, 173);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(45, 13);
            this.lbl_ver.TabIndex = 6;
            this.lbl_ver.Text = "%VER%";
            this.btn_tooltip.SetToolTip(this.lbl_ver, "This is the Current Version that you\'re using.");
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_update.Location = new System.Drawing.Point(459, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 44);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE";
            this.btn_tooltip.SetToolTip(this.btn_update, "Check for Application updates.");
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_tooltip
            // 
            this.btn_tooltip.AutoPopDelay = 8000;
            this.btn_tooltip.InitialDelay = 300;
            this.btn_tooltip.IsBalloon = true;
            this.btn_tooltip.ReshowDelay = 100;
            this.btn_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.btn_tooltip.ToolTipTitle = "Function Information: ";
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_settings.Location = new System.Drawing.Point(166, 81);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(118, 44);
            this.btn_settings.TabIndex = 10;
            this.btn_settings.Text = "SETTINGS";
            this.btn_tooltip.SetToolTip(this.btn_settings, "Download Resources again, if they haven\'t already been downloaded.");
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Transparent;
            this.pnl.BackgroundImage = global::Portable_Minecraft_Launcher.Properties.Resources.IRONAXE_LOGO;
            this.pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(604, 186);
            this.pnl.TabIndex = 8;
            this.pnl.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portable_Minecraft_Launcher.Properties.Resources.PML_PNL;
            this.ClientSize = new System.Drawing.Size(604, 186);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.btn_profile_load);
            this.Controls.Add(this.btn_profile_create);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portable Minecraft Launcher: Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_profile_create;
        private System.Windows.Forms.Button btn_profile_load;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ToolTip btn_tooltip;
        private System.Windows.Forms.PictureBox pnl;
        private System.Windows.Forms.Button btn_settings;
    }
}

