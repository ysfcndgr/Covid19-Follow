namespace Covid19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnOff = new System.Windows.Forms.Button();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.infoPictureList = new System.Windows.Forms.PictureBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.result6 = new System.Windows.Forms.Label();
            this.result5 = new System.Windows.Forms.Label();
            this.result4 = new System.Windows.Forms.Label();
            this.result3 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.total_recovered = new System.Windows.Forms.Label();
            this.new_recovered = new System.Windows.Forms.Label();
            this.total_deaths = new System.Windows.Forms.Label();
            this.new_deaths = new System.Windows.Forms.Label();
            this.total_confirmed = new System.Windows.Forms.Label();
            this.new_confirmed = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.ComboBox();
            this.rightImg = new System.Windows.Forms.PictureBox();
            this.borderPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureList)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOff.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
            this.btnOff.Location = new System.Drawing.Point(732, 0);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(38, 40);
            this.btnOff.TabIndex = 0;
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // borderPanel
            // 
            this.borderPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borderPanel.BackgroundImage")));
            this.borderPanel.Controls.Add(this.btnOff);
            this.borderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderPanel.Location = new System.Drawing.Point(0, 0);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(770, 40);
            this.borderPanel.TabIndex = 1;
            this.borderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderPanel_MouseDown);
            this.borderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderPanel_MouseMove);
            this.borderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderPanel_MouseUp);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.infoPictureList);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 40);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(279, 360);
            this.leftPanel.TabIndex = 5;
            // 
            // infoPictureList
            // 
            this.infoPictureList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPictureList.Image = ((System.Drawing.Image)(resources.GetObject("infoPictureList.Image")));
            this.infoPictureList.Location = new System.Drawing.Point(0, 0);
            this.infoPictureList.Name = "infoPictureList";
            this.infoPictureList.Size = new System.Drawing.Size(279, 360);
            this.infoPictureList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPictureList.TabIndex = 0;
            this.infoPictureList.TabStop = false;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Controls.Add(this.rightImg);
            this.rightPanel.Controls.Add(this.result6);
            this.rightPanel.Controls.Add(this.result5);
            this.rightPanel.Controls.Add(this.result4);
            this.rightPanel.Controls.Add(this.result3);
            this.rightPanel.Controls.Add(this.result2);
            this.rightPanel.Controls.Add(this.result1);
            this.rightPanel.Controls.Add(this.total_recovered);
            this.rightPanel.Controls.Add(this.new_recovered);
            this.rightPanel.Controls.Add(this.total_deaths);
            this.rightPanel.Controls.Add(this.new_deaths);
            this.rightPanel.Controls.Add(this.total_confirmed);
            this.rightPanel.Controls.Add(this.new_confirmed);
            this.rightPanel.Controls.Add(this.lbl_location);
            this.rightPanel.Controls.Add(this.location);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.ForeColor = System.Drawing.Color.Transparent;
            this.rightPanel.Location = new System.Drawing.Point(279, 40);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(491, 360);
            this.rightPanel.TabIndex = 6;
            // 
            // result6
            // 
            this.result6.AutoSize = true;
            this.result6.BackColor = System.Drawing.Color.Transparent;
            this.result6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.result6.Location = new System.Drawing.Point(163, 281);
            this.result6.Name = "result6";
            this.result6.Size = new System.Drawing.Size(0, 23);
            this.result6.TabIndex = 17;
            // 
            // result5
            // 
            this.result5.AutoSize = true;
            this.result5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.result5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.result5.Location = new System.Drawing.Point(154, 237);
            this.result5.Name = "result5";
            this.result5.Size = new System.Drawing.Size(0, 23);
            this.result5.TabIndex = 16;
            // 
            // result4
            // 
            this.result4.AutoSize = true;
            this.result4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.result4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.result4.Location = new System.Drawing.Point(132, 193);
            this.result4.Name = "result4";
            this.result4.Size = new System.Drawing.Size(0, 23);
            this.result4.TabIndex = 15;
            // 
            // result3
            // 
            this.result3.AutoSize = true;
            this.result3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.result3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.result3.Location = new System.Drawing.Point(132, 150);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(0, 23);
            this.result3.TabIndex = 14;
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.result2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.result2.Location = new System.Drawing.Point(163, 109);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(0, 23);
            this.result2.TabIndex = 13;
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.result1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.result1.Location = new System.Drawing.Point(163, 63);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(0, 23);
            this.result1.TabIndex = 12;
            // 
            // total_recovered
            // 
            this.total_recovered.AutoSize = true;
            this.total_recovered.BackColor = System.Drawing.Color.Transparent;
            this.total_recovered.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_recovered.ForeColor = System.Drawing.Color.LightGray;
            this.total_recovered.Location = new System.Drawing.Point(13, 281);
            this.total_recovered.Name = "total_recovered";
            this.total_recovered.Size = new System.Drawing.Size(152, 23);
            this.total_recovered.TabIndex = 11;
            this.total_recovered.Text = "Total Recovered:";
            // 
            // new_recovered
            // 
            this.new_recovered.AutoSize = true;
            this.new_recovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.new_recovered.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.new_recovered.ForeColor = System.Drawing.Color.Gainsboro;
            this.new_recovered.Location = new System.Drawing.Point(13, 237);
            this.new_recovered.Name = "new_recovered";
            this.new_recovered.Size = new System.Drawing.Size(146, 23);
            this.new_recovered.TabIndex = 10;
            this.new_recovered.Text = "New Recovered:";
            // 
            // total_deaths
            // 
            this.total_deaths.AutoSize = true;
            this.total_deaths.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.total_deaths.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_deaths.ForeColor = System.Drawing.Color.LightGray;
            this.total_deaths.Location = new System.Drawing.Point(13, 193);
            this.total_deaths.Name = "total_deaths";
            this.total_deaths.Size = new System.Drawing.Size(124, 23);
            this.total_deaths.TabIndex = 9;
            this.total_deaths.Text = "Total Deaths:";
            // 
            // new_deaths
            // 
            this.new_deaths.AutoSize = true;
            this.new_deaths.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.new_deaths.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.new_deaths.ForeColor = System.Drawing.Color.LightGray;
            this.new_deaths.Location = new System.Drawing.Point(13, 150);
            this.new_deaths.Name = "new_deaths";
            this.new_deaths.Size = new System.Drawing.Size(118, 23);
            this.new_deaths.TabIndex = 8;
            this.new_deaths.Text = "New Deaths:";
            // 
            // total_confirmed
            // 
            this.total_confirmed.AutoSize = true;
            this.total_confirmed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.total_confirmed.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_confirmed.ForeColor = System.Drawing.Color.LightGray;
            this.total_confirmed.Location = new System.Drawing.Point(13, 109);
            this.total_confirmed.Name = "total_confirmed";
            this.total_confirmed.Size = new System.Drawing.Size(155, 23);
            this.total_confirmed.TabIndex = 7;
            this.total_confirmed.Text = "Total Confirmed:";
            // 
            // new_confirmed
            // 
            this.new_confirmed.AutoSize = true;
            this.new_confirmed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.new_confirmed.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.new_confirmed.ForeColor = System.Drawing.Color.LightGray;
            this.new_confirmed.Location = new System.Drawing.Point(13, 63);
            this.new_confirmed.Name = "new_confirmed";
            this.new_confirmed.Size = new System.Drawing.Size(154, 23);
            this.new_confirmed.TabIndex = 6;
            this.new_confirmed.Text = "New Confirmed :";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_location.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_location.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_location.Location = new System.Drawing.Point(13, 15);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(90, 23);
            this.lbl_location.TabIndex = 5;
            this.lbl_location.Text = "Location:";
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.location.DropDownHeight = 320;
            this.location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.location.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.location.ForeColor = System.Drawing.Color.LightCyan;
            this.location.FormattingEnabled = true;
            this.location.IntegralHeight = false;
            this.location.ItemHeight = 14;
            this.location.Location = new System.Drawing.Point(109, 17);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(146, 22);
            this.location.TabIndex = 2;
            this.location.Text = "Countries";
            this.location.SelectedValueChanged += new System.EventHandler(this.location_SelectedValueChanged);
            // 
            // rightImg
            // 
            this.rightImg.Image = ((System.Drawing.Image)(resources.GetObject("rightImg.Image")));
            this.rightImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("rightImg.InitialImage")));
            this.rightImg.Location = new System.Drawing.Point(256, 82);
            this.rightImg.Name = "rightImg";
            this.rightImg.Size = new System.Drawing.Size(222, 155);
            this.rightImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightImg.TabIndex = 18;
            this.rightImg.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(770, 400);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.borderPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid-19 Map";
            this.Load += new System.EventHandler(this.Main_Load);
            this.borderPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureList)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.PictureBox infoPictureList;
        private System.Windows.Forms.Label result6;
        private System.Windows.Forms.Label result5;
        private System.Windows.Forms.Label result4;
        private System.Windows.Forms.Label result3;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Label total_recovered;
        private System.Windows.Forms.Label new_recovered;
        private System.Windows.Forms.Label total_deaths;
        private System.Windows.Forms.Label new_deaths;
        private System.Windows.Forms.Label total_confirmed;
        private System.Windows.Forms.Label new_confirmed;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.PictureBox rightImg;
    }
}

