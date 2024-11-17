
namespace switch_logo_patcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BootLogo_Button = new System.Windows.Forms.Button();
            this.Disk = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Background_hbmenu_Button = new System.Windows.Forms.Button();
            this.Background_hekate_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete_button1 = new System.Windows.Forms.Button();
            this.Background_hbmenu_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete_button2 = new System.Windows.Forms.Button();
            this.Background_hekate_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Delete_button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bootlogo_final_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bootlogo_original_pictureBox = new System.Windows.Forms.PictureBox();
            this.Create_button = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Delete_button3 = new System.Windows.Forms.Button();
            this.SplashScreen_pictureBox = new System.Windows.Forms.PictureBox();
            this.Hekate_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Background_hbmenu_pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Background_hekate_pictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bootlogo_final_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootlogo_original_pictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreen_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BootLogo_Button
            // 
            this.BootLogo_Button.Location = new System.Drawing.Point(12, 204);
            this.BootLogo_Button.Name = "BootLogo_Button";
            this.BootLogo_Button.Size = new System.Drawing.Size(199, 23);
            this.BootLogo_Button.TabIndex = 0;
            this.BootLogo_Button.Text = "Boot Logo";
            this.BootLogo_Button.UseVisualStyleBackColor = true;
            this.BootLogo_Button.Click += new System.EventHandler(this.BootLogo_Button_Click);
            // 
            // Disk
            // 
            this.Disk.FormattingEnabled = true;
            this.Disk.Items.AddRange(new object[] {
            "\"Select your disk\""});
            this.Disk.Location = new System.Drawing.Point(12, 12);
            this.Disk.Name = "Disk";
            this.Disk.Size = new System.Drawing.Size(199, 23);
            this.Disk.TabIndex = 1;
            this.Disk.SelectedIndexChanged += new System.EventHandler(this.Disk_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::switch_logo_patcher.Properties.Resources.switch_nocheck;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Background_hbmenu_Button
            // 
            this.Background_hbmenu_Button.Location = new System.Drawing.Point(12, 117);
            this.Background_hbmenu_Button.Name = "Background_hbmenu_Button";
            this.Background_hbmenu_Button.Size = new System.Drawing.Size(199, 23);
            this.Background_hbmenu_Button.TabIndex = 3;
            this.Background_hbmenu_Button.Text = "Background Homebrew Menu";
            this.Background_hbmenu_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Background_hbmenu_Button.UseVisualStyleBackColor = true;
            this.Background_hbmenu_Button.Click += new System.EventHandler(this.Background_hbmenu_Click);
            // 
            // Background_hekate_Button
            // 
            this.Background_hekate_Button.Location = new System.Drawing.Point(12, 146);
            this.Background_hekate_Button.Name = "Background_hekate_Button";
            this.Background_hekate_Button.Size = new System.Drawing.Size(199, 23);
            this.Background_hekate_Button.TabIndex = 4;
            this.Background_hekate_Button.Text = "Background hekate";
            this.Background_hekate_Button.UseVisualStyleBackColor = true;
            this.Background_hekate_Button.Click += new System.EventHandler(this.Background_hekate_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete_button1);
            this.groupBox1.Controls.Add(this.Background_hbmenu_pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 215);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background Homebrew Menu";
            // 
            // Delete_button1
            // 
            this.Delete_button1.BackColor = System.Drawing.Color.Transparent;
            this.Delete_button1.BackgroundImage = global::switch_logo_patcher.Properties.Resources.delete;
            this.Delete_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete_button1.Location = new System.Drawing.Point(376, 179);
            this.Delete_button1.Name = "Delete_button1";
            this.Delete_button1.Size = new System.Drawing.Size(30, 30);
            this.Delete_button1.TabIndex = 12;
            this.Delete_button1.UseVisualStyleBackColor = false;
            this.Delete_button1.Click += new System.EventHandler(this.Delete_button1_Click);
            // 
            // Background_hbmenu_pictureBox
            // 
            this.Background_hbmenu_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Background_hbmenu_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background_hbmenu_pictureBox.Location = new System.Drawing.Point(3, 19);
            this.Background_hbmenu_pictureBox.Name = "Background_hbmenu_pictureBox";
            this.Background_hbmenu_pictureBox.Size = new System.Drawing.Size(406, 193);
            this.Background_hbmenu_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Background_hbmenu_pictureBox.TabIndex = 0;
            this.Background_hbmenu_pictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete_button2);
            this.groupBox2.Controls.Add(this.Background_hekate_pictureBox);
            this.groupBox2.Location = new System.Drawing.Point(635, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 215);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Background hekate";
            // 
            // Delete_button2
            // 
            this.Delete_button2.BackColor = System.Drawing.Color.Transparent;
            this.Delete_button2.BackgroundImage = global::switch_logo_patcher.Properties.Resources.delete;
            this.Delete_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete_button2.Location = new System.Drawing.Point(376, 179);
            this.Delete_button2.Name = "Delete_button2";
            this.Delete_button2.Size = new System.Drawing.Size(30, 30);
            this.Delete_button2.TabIndex = 13;
            this.Delete_button2.UseVisualStyleBackColor = false;
            this.Delete_button2.Click += new System.EventHandler(this.Delete_button2_Click);
            // 
            // Background_hekate_pictureBox
            // 
            this.Background_hekate_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Background_hekate_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background_hekate_pictureBox.Location = new System.Drawing.Point(3, 19);
            this.Background_hekate_pictureBox.Name = "Background_hekate_pictureBox";
            this.Background_hekate_pictureBox.Size = new System.Drawing.Size(406, 193);
            this.Background_hekate_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Background_hekate_pictureBox.TabIndex = 0;
            this.Background_hekate_pictureBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Delete_button4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.bootlogo_final_pictureBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.bootlogo_original_pictureBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(617, 333);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "bootlogo";
            // 
            // Delete_button4
            // 
            this.Delete_button4.BackColor = System.Drawing.Color.Transparent;
            this.Delete_button4.BackgroundImage = global::switch_logo_patcher.Properties.Resources.delete;
            this.Delete_button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete_button4.Location = new System.Drawing.Point(581, 295);
            this.Delete_button4.Name = "Delete_button4";
            this.Delete_button4.Size = new System.Drawing.Size(30, 30);
            this.Delete_button4.TabIndex = 15;
            this.Delete_button4.UseVisualStyleBackColor = false;
            this.Delete_button4.Click += new System.EventHandler(this.Delete_button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(468, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final";
            // 
            // bootlogo_final_pictureBox
            // 
            this.bootlogo_final_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bootlogo_final_pictureBox.Location = new System.Drawing.Point(358, 29);
            this.bootlogo_final_pictureBox.Name = "bootlogo_final_pictureBox";
            this.bootlogo_final_pictureBox.Size = new System.Drawing.Size(253, 296);
            this.bootlogo_final_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bootlogo_final_pictureBox.TabIndex = 2;
            this.bootlogo_final_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original";
            // 
            // bootlogo_original_pictureBox
            // 
            this.bootlogo_original_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bootlogo_original_pictureBox.Location = new System.Drawing.Point(6, 31);
            this.bootlogo_original_pictureBox.Name = "bootlogo_original_pictureBox";
            this.bootlogo_original_pictureBox.Size = new System.Drawing.Size(314, 296);
            this.bootlogo_original_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bootlogo_original_pictureBox.TabIndex = 0;
            this.bootlogo_original_pictureBox.TabStop = false;
            // 
            // Create_button
            // 
            this.Create_button.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Create_button.Location = new System.Drawing.Point(635, 451);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(415, 115);
            this.Create_button.TabIndex = 9;
            this.Create_button.Text = "Create";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Delete_button3);
            this.groupBox5.Controls.Add(this.SplashScreen_pictureBox);
            this.groupBox5.Location = new System.Drawing.Point(638, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(412, 215);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Splash Screen";
            // 
            // Delete_button3
            // 
            this.Delete_button3.BackColor = System.Drawing.Color.Transparent;
            this.Delete_button3.BackgroundImage = global::switch_logo_patcher.Properties.Resources.delete;
            this.Delete_button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete_button3.Location = new System.Drawing.Point(417, 208);
            this.Delete_button3.Name = "Delete_button3";
            this.Delete_button3.Size = new System.Drawing.Size(30, 30);
            this.Delete_button3.TabIndex = 14;
            this.Delete_button3.UseVisualStyleBackColor = false;
            this.Delete_button3.Click += new System.EventHandler(this.Delete_button3_Click);
            // 
            // SplashScreen_pictureBox
            // 
            this.SplashScreen_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplashScreen_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplashScreen_pictureBox.Location = new System.Drawing.Point(3, 19);
            this.SplashScreen_pictureBox.Name = "SplashScreen_pictureBox";
            this.SplashScreen_pictureBox.Size = new System.Drawing.Size(406, 193);
            this.SplashScreen_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SplashScreen_pictureBox.TabIndex = 0;
            this.SplashScreen_pictureBox.TabStop = false;
            // 
            // Hekate_button
            // 
            this.Hekate_button.Location = new System.Drawing.Point(12, 175);
            this.Hekate_button.Name = "Hekate_button";
            this.Hekate_button.Size = new System.Drawing.Size(199, 23);
            this.Hekate_button.TabIndex = 11;
            this.Hekate_button.Text = "SplashScreen";
            this.Hekate_button.UseVisualStyleBackColor = true;
            this.Hekate_button.Click += new System.EventHandler(this.Hekate_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 587);
            this.Controls.Add(this.Hekate_button);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Background_hekate_Button);
            this.Controls.Add(this.Background_hbmenu_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Disk);
            this.Controls.Add(this.BootLogo_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1074, 626);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwitchCustomizer 0.9.19";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Background_hbmenu_pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Background_hekate_pictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bootlogo_final_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootlogo_original_pictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreen_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BootLogo_Button;
        private System.Windows.Forms.ComboBox Disk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Background_hbmenu_Button;
        private System.Windows.Forms.Button Background_hekate_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Background_hbmenu_pictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Background_hekate_pictureBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox bootlogo_final_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bootlogo_original_pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox SplashScreen_pictureBox;
        private System.Windows.Forms.Button Hekate_button;
        private System.Windows.Forms.Button Delete_button1;
        private System.Windows.Forms.Button Delete_button2;
        private System.Windows.Forms.Button Delete_button4;
        private System.Windows.Forms.Button Delete_button3;
    }
}

