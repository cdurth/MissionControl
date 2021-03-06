﻿namespace MissionControl
{
    partial class MissionControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public System.Collections.Generic.List<MetroFramework.Controls.MetroTile> tileList = new System.Collections.Generic.List<MetroFramework.Controls.MetroTile>();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissionControl));
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pad_9 = new MetroFramework.Controls.MetroTile();
            this.pad_12 = new MetroFramework.Controls.MetroTile();
            this.pad_11 = new MetroFramework.Controls.MetroTile();
            this.pad_10 = new MetroFramework.Controls.MetroTile();
            this.pad_5 = new MetroFramework.Controls.MetroTile();
            this.pad_8 = new MetroFramework.Controls.MetroTile();
            this.pad_7 = new MetroFramework.Controls.MetroTile();
            this.pad_6 = new MetroFramework.Controls.MetroTile();
            this.pad_1 = new MetroFramework.Controls.MetroTile();
            this.pad_4 = new MetroFramework.Controls.MetroTile();
            this.pad_3 = new MetroFramework.Controls.MetroTile();
            this.pad_2 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tb_port = new MetroFramework.Controls.MetroTextBox();
            this.btn_ping = new MetroFramework.Controls.MetroButton();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.btn_reset = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_armcode = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.tb_server = new MetroFramework.Controls.MetroTextBox();
            this.btn_launch = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_load = new MetroFramework.Controls.MetroButton();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.metroTabPage1);
            this.Tabs.Location = new System.Drawing.Point(3, 63);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(494, 376);
            this.Tabs.TabIndex = 0;
            this.Tabs.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pad_9);
            this.tabPage1.Controls.Add(this.pad_12);
            this.tabPage1.Controls.Add(this.pad_11);
            this.tabPage1.Controls.Add(this.pad_10);
            this.tabPage1.Controls.Add(this.pad_5);
            this.tabPage1.Controls.Add(this.pad_8);
            this.tabPage1.Controls.Add(this.pad_7);
            this.tabPage1.Controls.Add(this.pad_6);
            this.tabPage1.Controls.Add(this.pad_1);
            this.tabPage1.Controls.Add(this.pad_4);
            this.tabPage1.Controls.Add(this.pad_3);
            this.tabPage1.Controls.Add(this.pad_2);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pad_9
            // 
            this.pad_9.Location = new System.Drawing.Point(13, 226);
            this.pad_9.Name = "pad_9";
            this.pad_9.Size = new System.Drawing.Size(105, 98);
            this.pad_9.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_9.TabIndex = 20;
            this.pad_9.Text = "Pad 9";
            this.pad_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_9.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_12
            // 
            this.pad_12.Location = new System.Drawing.Point(369, 228);
            this.pad_12.Name = "pad_12";
            this.pad_12.Size = new System.Drawing.Size(105, 98);
            this.pad_12.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_12.TabIndex = 19;
            this.pad_12.Text = "Pad 12";
            this.pad_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_12.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_11
            // 
            this.pad_11.Location = new System.Drawing.Point(250, 228);
            this.pad_11.Name = "pad_11";
            this.pad_11.Size = new System.Drawing.Size(105, 98);
            this.pad_11.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_11.TabIndex = 18;
            this.pad_11.Text = "Pad 11";
            this.pad_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_11.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_10
            // 
            this.pad_10.Location = new System.Drawing.Point(131, 227);
            this.pad_10.Name = "pad_10";
            this.pad_10.Size = new System.Drawing.Size(105, 98);
            this.pad_10.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_10.TabIndex = 17;
            this.pad_10.Text = "Pad 10";
            this.pad_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_10.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_5
            // 
            this.pad_5.Location = new System.Drawing.Point(13, 119);
            this.pad_5.Name = "pad_5";
            this.pad_5.Size = new System.Drawing.Size(105, 98);
            this.pad_5.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_5.TabIndex = 16;
            this.pad_5.Text = "Pad 5";
            this.pad_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_5.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_8
            // 
            this.pad_8.Location = new System.Drawing.Point(369, 121);
            this.pad_8.Name = "pad_8";
            this.pad_8.Size = new System.Drawing.Size(105, 98);
            this.pad_8.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_8.TabIndex = 15;
            this.pad_8.Text = "Pad 8";
            this.pad_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_8.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_7
            // 
            this.pad_7.Location = new System.Drawing.Point(250, 121);
            this.pad_7.Name = "pad_7";
            this.pad_7.Size = new System.Drawing.Size(105, 98);
            this.pad_7.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_7.TabIndex = 14;
            this.pad_7.Text = "Pad 7";
            this.pad_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_7.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_6
            // 
            this.pad_6.Location = new System.Drawing.Point(131, 120);
            this.pad_6.Name = "pad_6";
            this.pad_6.Size = new System.Drawing.Size(105, 98);
            this.pad_6.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_6.TabIndex = 13;
            this.pad_6.Text = "Pad 6";
            this.pad_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_6.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_1
            // 
            this.pad_1.Location = new System.Drawing.Point(13, 13);
            this.pad_1.Name = "pad_1";
            this.pad_1.Size = new System.Drawing.Size(105, 98);
            this.pad_1.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_1.TabIndex = 12;
            this.pad_1.Text = "Pad 1";
            this.pad_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_1.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_4
            // 
            this.pad_4.Location = new System.Drawing.Point(369, 15);
            this.pad_4.Name = "pad_4";
            this.pad_4.Size = new System.Drawing.Size(105, 98);
            this.pad_4.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_4.TabIndex = 11;
            this.pad_4.Text = "Pad 4";
            this.pad_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_4.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_3
            // 
            this.pad_3.Location = new System.Drawing.Point(250, 15);
            this.pad_3.Name = "pad_3";
            this.pad_3.Size = new System.Drawing.Size(105, 98);
            this.pad_3.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_3.TabIndex = 10;
            this.pad_3.Text = "Pad 3";
            this.pad_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_3.Click += new System.EventHandler(this.timer_dialog);
            // 
            // pad_2
            // 
            this.pad_2.Location = new System.Drawing.Point(131, 14);
            this.pad_2.Name = "pad_2";
            this.pad_2.Size = new System.Drawing.Size(105, 98);
            this.pad_2.Style = MetroFramework.MetroColorStyle.Silver;
            this.pad_2.TabIndex = 9;
            this.pad_2.Text = "Pad 2";
            this.pad_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pad_2.Click += new System.EventHandler(this.timer_dialog);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.tb_port);
            this.metroTabPage1.Controls.Add(this.btn_ping);
            this.metroTabPage1.Controls.Add(this.btn_save);
            this.metroTabPage1.Controls.Add(this.btn_reset);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.tb_armcode);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.tb_server);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(486, 337);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Settings";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 72);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Port";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(16, 94);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(86, 20);
            this.tb_port.TabIndex = 3;
            // 
            // btn_ping
            // 
            this.btn_ping.Location = new System.Drawing.Point(239, 201);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(101, 23);
            this.btn_ping.TabIndex = 11;
            this.btn_ping.Text = "Ping Server";
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(16, 201);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save Settings";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(239, 147);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(101, 23);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset Pads";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroLabel3.TabIndex = 14;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroLabel2.TabIndex = 15;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Arm Code";
            // 
            // tb_armcode
            // 
            this.tb_armcode.Location = new System.Drawing.Point(16, 147);
            this.tb_armcode.Name = "tb_armcode";
            this.tb_armcode.PasswordChar = '*';
            this.tb_armcode.Size = new System.Drawing.Size(150, 20);
            this.tb_armcode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESP8266 IP";
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(16, 39);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(150, 20);
            this.tb_server.TabIndex = 2;
            // 
            // btn_launch
            // 
            this.btn_launch.Location = new System.Drawing.Point(503, 357);
            this.btn_launch.Name = "btn_launch";
            this.btn_launch.Size = new System.Drawing.Size(256, 67);
            this.btn_launch.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_launch.TabIndex = 1;
            this.btn_launch.Text = "LAUNCH";
            this.btn_launch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_launch.Click += new System.EventHandler(this.btn_launch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(503, 284);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(256, 67);
            this.btn_load.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_load.TabIndex = 10;
            this.btn_load.Text = "LOAD";
            this.btn_load.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // MissionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_launch);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MissionControl";
            this.Resizable = false;
            this.Text = "Mission Control";
            this.Load += new System.EventHandler(this.MissionControl_Load);
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroTabControl Tabs;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btn_launch;
        private MetroFramework.Controls.MetroTile pad_4;
        private MetroFramework.Controls.MetroTile pad_3;
        private MetroFramework.Controls.MetroTile pad_2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile pad_1;
        private MetroFramework.Controls.MetroTile pad_9;
        private MetroFramework.Controls.MetroTile pad_12;
        private MetroFramework.Controls.MetroTile pad_11;
        private MetroFramework.Controls.MetroTile pad_10;
        private MetroFramework.Controls.MetroTile pad_5;
        private MetroFramework.Controls.MetroTile pad_8;
        private MetroFramework.Controls.MetroTile pad_7;
        private MetroFramework.Controls.MetroTile pad_6;
        private MetroFramework.Controls.MetroTextBox tb_server;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox tb_armcode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_reset;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroButton btn_ping;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tb_port;
        private MetroFramework.Controls.MetroButton btn_load;
    }
}

