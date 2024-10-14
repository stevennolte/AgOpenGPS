namespace AgOpenGPS.Forms
{
    partial class Form_Health
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBoxPowerHealth = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGPSHealth = new System.Windows.Forms.PictureBox();
            this.pictureBoxCANBUSHealth = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGPSHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCANBUSHealth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 533);
            this.panel1.TabIndex = 10;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pictureBoxPowerHealth);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.pictureBoxGPSHealth);
            this.panelMain.Controls.Add(this.pictureBoxCANBUSHealth);
            this.panelMain.Location = new System.Drawing.Point(4, 4);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1020, 105);
            this.panelMain.TabIndex = 19;
            // 
            // pictureBoxPowerHealth
            // 
            this.pictureBoxPowerHealth.Image = global::AgOpenGPS.Properties.Resources.Power_Active;
            this.pictureBoxPowerHealth.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxPowerHealth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPowerHealth.Name = "pictureBoxPowerHealth";
            this.pictureBoxPowerHealth.Size = new System.Drawing.Size(107, 96);
            this.pictureBoxPowerHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPowerHealth.TabIndex = 17;
            this.pictureBoxPowerHealth.TabStop = false;
            this.pictureBoxPowerHealth.Click += new System.EventHandler(this.powerMonitorButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgOpenGPS.Properties.Resources.Update1;
            this.pictureBox1.Location = new System.Drawing.Point(555, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxGPSHealth
            // 
            this.pictureBoxGPSHealth.Image = global::AgOpenGPS.Properties.Resources.GPS_Off;
            this.pictureBoxGPSHealth.Location = new System.Drawing.Point(119, 4);
            this.pictureBoxGPSHealth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxGPSHealth.Name = "pictureBoxGPSHealth";
            this.pictureBoxGPSHealth.Size = new System.Drawing.Size(107, 96);
            this.pictureBoxGPSHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGPSHealth.TabIndex = 18;
            this.pictureBoxGPSHealth.TabStop = false;
            // 
            // pictureBoxCANBUSHealth
            // 
            this.pictureBoxCANBUSHealth.Image = global::AgOpenGPS.Properties.Resources.CANBUS_Off;
            this.pictureBoxCANBUSHealth.Location = new System.Drawing.Point(233, 4);
            this.pictureBoxCANBUSHealth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCANBUSHealth.Name = "pictureBoxCANBUSHealth";
            this.pictureBoxCANBUSHealth.Size = new System.Drawing.Size(107, 96);
            this.pictureBoxCANBUSHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCANBUSHealth.TabIndex = 16;
            this.pictureBoxCANBUSHealth.TabStop = false;
            // 
            // Form_Health
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1211, 533);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Health";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Health_Load);
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGPSHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCANBUSHealth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxCANBUSHealth;
        private System.Windows.Forms.PictureBox pictureBoxPowerHealth;
        private System.Windows.Forms.PictureBox pictureBoxGPSHealth;
        private System.Windows.Forms.Panel panelMain;
    }
}