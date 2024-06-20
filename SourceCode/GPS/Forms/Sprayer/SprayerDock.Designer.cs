namespace AgOpenGPS.Forms.Sprayer
{
    partial class SprayerDock
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
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pbRailFlowrate = new ReaLTaiizor.Controls.CyberProgressBar();
            this.cyberProgressBar1 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.lblpbFlowTarget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new ReaLTaiizor.Controls.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cyberProgressBar2 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.cyberProgressBar3 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.toggleAutoControl = new ReaLTaiizor.Controls.ForeverToggle();
            this.label37 = new System.Windows.Forms.Label();
            this.toggleRemote = new ReaLTaiizor.Controls.ForeverToggle();
            this.toggleProductEnable = new ReaLTaiizor.Controls.ForeverToggle();
            this.label36 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModuleReboot = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblpbFlowTarget);
            this.panel1.Controls.Add(this.cyberProgressBar1);
            this.panel1.Controls.Add(this.pbRailFlowrate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(198, 85);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(69, -1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 34);
            this.label13.TabIndex = 16;
            this.label13.Text = "FLOW";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbRailFlowrate
            // 
            this.pbRailFlowrate.Alpha = 50;
            this.pbRailFlowrate.BackColor = System.Drawing.Color.Transparent;
            this.pbRailFlowrate.Background = true;
            this.pbRailFlowrate.Background_WidthPen = 3F;
            this.pbRailFlowrate.BackgroundPen = true;
            this.pbRailFlowrate.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailFlowrate.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailFlowrate.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRailFlowrate.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.pbRailFlowrate.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailFlowrate.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.pbRailFlowrate.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailFlowrate.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailFlowrate.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRailFlowrate.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailFlowrate.ColorValue_Transparency = 200;
            this.pbRailFlowrate.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.pbRailFlowrate.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRailFlowrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRailFlowrate.Lighting = false;
            this.pbRailFlowrate.LinearGradient_Background = false;
            this.pbRailFlowrate.LinearGradient_Value = false;
            this.pbRailFlowrate.LinearGradientPen = false;
            this.pbRailFlowrate.Location = new System.Drawing.Point(48, 30);
            this.pbRailFlowrate.Maximum = 10000;
            this.pbRailFlowrate.Minimum = 0;
            this.pbRailFlowrate.Name = "pbRailFlowrate";
            this.pbRailFlowrate.PenWidth = 10;
            this.pbRailFlowrate.ProgressText = false;
            this.pbRailFlowrate.RGB = false;
            this.pbRailFlowrate.Rounding = true;
            this.pbRailFlowrate.RoundingInt = 15;
            this.pbRailFlowrate.Size = new System.Drawing.Size(136, 20);
            this.pbRailFlowrate.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pbRailFlowrate.StartDrawingValue = 0;
            this.pbRailFlowrate.TabIndex = 29;
            this.pbRailFlowrate.Tag = "Cyber";
            this.pbRailFlowrate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pbRailFlowrate.Timer_RGB = 300;
            this.pbRailFlowrate.Value = 0;
            // 
            // cyberProgressBar1
            // 
            this.cyberProgressBar1.Alpha = 50;
            this.cyberProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.cyberProgressBar1.Background = true;
            this.cyberProgressBar1.Background_WidthPen = 3F;
            this.cyberProgressBar1.BackgroundPen = true;
            this.cyberProgressBar1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar1.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar1.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar1.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.cyberProgressBar1.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar1.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberProgressBar1.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar1.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar1.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar1.ColorValue_Transparency = 200;
            this.cyberProgressBar1.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberProgressBar1.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar1.Lighting = false;
            this.cyberProgressBar1.LinearGradient_Background = false;
            this.cyberProgressBar1.LinearGradient_Value = false;
            this.cyberProgressBar1.LinearGradientPen = false;
            this.cyberProgressBar1.Location = new System.Drawing.Point(48, 53);
            this.cyberProgressBar1.Maximum = 10000;
            this.cyberProgressBar1.Minimum = 0;
            this.cyberProgressBar1.Name = "cyberProgressBar1";
            this.cyberProgressBar1.PenWidth = 10;
            this.cyberProgressBar1.ProgressText = false;
            this.cyberProgressBar1.RGB = false;
            this.cyberProgressBar1.Rounding = true;
            this.cyberProgressBar1.RoundingInt = 15;
            this.cyberProgressBar1.Size = new System.Drawing.Size(136, 20);
            this.cyberProgressBar1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberProgressBar1.StartDrawingValue = 0;
            this.cyberProgressBar1.TabIndex = 30;
            this.cyberProgressBar1.Tag = "Cyber";
            this.cyberProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberProgressBar1.Timer_RGB = 300;
            this.cyberProgressBar1.Value = 0;
            // 
            // lblpbFlowTarget
            // 
            this.lblpbFlowTarget.AutoSize = true;
            this.lblpbFlowTarget.BackColor = System.Drawing.Color.Transparent;
            this.lblpbFlowTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpbFlowTarget.ForeColor = System.Drawing.Color.White;
            this.lblpbFlowTarget.Location = new System.Drawing.Point(10, 34);
            this.lblpbFlowTarget.Name = "lblpbFlowTarget";
            this.lblpbFlowTarget.Size = new System.Drawing.Size(32, 13);
            this.lblpbFlowTarget.TabIndex = 55;
            this.lblpbFlowTarget.Text = "0.00";
            this.lblpbFlowTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "0.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cyberProgressBar2);
            this.panel2.Controls.Add(this.cyberProgressBar3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel2.Location = new System.Drawing.Point(216, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(198, 85);
            this.panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel2.TabIndex = 57;
            this.panel2.Text = "panel2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "0.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "0.00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cyberProgressBar2
            // 
            this.cyberProgressBar2.Alpha = 50;
            this.cyberProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.cyberProgressBar2.Background = true;
            this.cyberProgressBar2.Background_WidthPen = 3F;
            this.cyberProgressBar2.BackgroundPen = true;
            this.cyberProgressBar2.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar2.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar2.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar2.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.cyberProgressBar2.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar2.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberProgressBar2.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar2.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar2.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar2.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar2.ColorValue_Transparency = 200;
            this.cyberProgressBar2.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberProgressBar2.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar2.Lighting = false;
            this.cyberProgressBar2.LinearGradient_Background = false;
            this.cyberProgressBar2.LinearGradient_Value = false;
            this.cyberProgressBar2.LinearGradientPen = false;
            this.cyberProgressBar2.Location = new System.Drawing.Point(48, 53);
            this.cyberProgressBar2.Maximum = 10000;
            this.cyberProgressBar2.Minimum = 0;
            this.cyberProgressBar2.Name = "cyberProgressBar2";
            this.cyberProgressBar2.PenWidth = 10;
            this.cyberProgressBar2.ProgressText = false;
            this.cyberProgressBar2.RGB = false;
            this.cyberProgressBar2.Rounding = true;
            this.cyberProgressBar2.RoundingInt = 15;
            this.cyberProgressBar2.Size = new System.Drawing.Size(136, 20);
            this.cyberProgressBar2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberProgressBar2.StartDrawingValue = 0;
            this.cyberProgressBar2.TabIndex = 30;
            this.cyberProgressBar2.Tag = "Cyber";
            this.cyberProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberProgressBar2.Timer_RGB = 300;
            this.cyberProgressBar2.Value = 0;
            // 
            // cyberProgressBar3
            // 
            this.cyberProgressBar3.Alpha = 50;
            this.cyberProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.cyberProgressBar3.Background = true;
            this.cyberProgressBar3.Background_WidthPen = 3F;
            this.cyberProgressBar3.BackgroundPen = true;
            this.cyberProgressBar3.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar3.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar3.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar3.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.cyberProgressBar3.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar3.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberProgressBar3.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar3.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar3.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar3.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar3.ColorValue_Transparency = 200;
            this.cyberProgressBar3.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberProgressBar3.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar3.Lighting = false;
            this.cyberProgressBar3.LinearGradient_Background = false;
            this.cyberProgressBar3.LinearGradient_Value = false;
            this.cyberProgressBar3.LinearGradientPen = false;
            this.cyberProgressBar3.Location = new System.Drawing.Point(48, 30);
            this.cyberProgressBar3.Maximum = 10000;
            this.cyberProgressBar3.Minimum = 0;
            this.cyberProgressBar3.Name = "cyberProgressBar3";
            this.cyberProgressBar3.PenWidth = 10;
            this.cyberProgressBar3.ProgressText = false;
            this.cyberProgressBar3.RGB = false;
            this.cyberProgressBar3.Rounding = true;
            this.cyberProgressBar3.RoundingInt = 15;
            this.cyberProgressBar3.Size = new System.Drawing.Size(136, 20);
            this.cyberProgressBar3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberProgressBar3.StartDrawingValue = 0;
            this.cyberProgressBar3.TabIndex = 29;
            this.cyberProgressBar3.Tag = "Cyber";
            this.cyberProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberProgressBar3.Timer_RGB = 300;
            this.cyberProgressBar3.Value = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "PRESSURE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toggleAutoControl
            // 
            this.toggleAutoControl.BackColor = System.Drawing.Color.Transparent;
            this.toggleAutoControl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.toggleAutoControl.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.toggleAutoControl.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.toggleAutoControl.Checked = false;
            this.toggleAutoControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleAutoControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toggleAutoControl.Location = new System.Drawing.Point(520, 49);
            this.toggleAutoControl.Name = "toggleAutoControl";
            this.toggleAutoControl.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.toggleAutoControl.Size = new System.Drawing.Size(76, 33);
            this.toggleAutoControl.TabIndex = 87;
            this.toggleAutoControl.Text = "foreverToggle1";
            this.toggleAutoControl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toggleAutoControl.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.toggleAutoControl.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.toggleAutoControl_CheckedChanged);
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Gray;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(434, 44);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(171, 41);
            this.label37.TabIndex = 88;
            this.label37.Text = "AUTO";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toggleRemote
            // 
            this.toggleRemote.BackColor = System.Drawing.Color.Transparent;
            this.toggleRemote.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.toggleRemote.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.toggleRemote.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.toggleRemote.Checked = false;
            this.toggleRemote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleRemote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toggleRemote.Location = new System.Drawing.Point(521, 4);
            this.toggleRemote.Name = "toggleRemote";
            this.toggleRemote.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.toggleRemote.Size = new System.Drawing.Size(76, 33);
            this.toggleRemote.TabIndex = 85;
            this.toggleRemote.Text = "toggleRemoteControl";
            this.toggleRemote.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toggleRemote.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            // 
            // toggleProductEnable
            // 
            this.toggleProductEnable.BackColor = System.Drawing.Color.Transparent;
            this.toggleProductEnable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.toggleProductEnable.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.toggleProductEnable.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.toggleProductEnable.Checked = false;
            this.toggleProductEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleProductEnable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toggleProductEnable.Location = new System.Drawing.Point(521, 93);
            this.toggleProductEnable.Name = "toggleProductEnable";
            this.toggleProductEnable.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.toggleProductEnable.Size = new System.Drawing.Size(76, 33);
            this.toggleProductEnable.TabIndex = 83;
            this.toggleProductEnable.Text = "foreverToggle1";
            this.toggleProductEnable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toggleProductEnable.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Gray;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(434, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(171, 41);
            this.label36.TabIndex = 86;
            this.label36.Text = "REMOTE";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 41);
            this.label5.TabIndex = 84;
            this.label5.Text = "ENABLE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModuleReboot
            // 
            this.btnModuleReboot.AutoSize = true;
            this.btnModuleReboot.BackgroundImage = global::AgOpenGPS.Properties.Resources.Reboot;
            this.btnModuleReboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModuleReboot.Location = new System.Drawing.Point(675, 9);
            this.btnModuleReboot.Name = "btnModuleReboot";
            this.btnModuleReboot.Size = new System.Drawing.Size(72, 112);
            this.btnModuleReboot.TabIndex = 89;
            this.btnModuleReboot.UseVisualStyleBackColor = true;
            this.btnModuleReboot.Click += new System.EventHandler(this.btnModuleReboot_Click);
            // 
            // SprayerDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1187, 143);
            this.Controls.Add(this.btnModuleReboot);
            this.Controls.Add(this.toggleAutoControl);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.toggleRemote);
            this.Controls.Add(this.toggleProductEnable);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SprayerDock";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.Label label13;
        private ReaLTaiizor.Controls.CyberProgressBar pbRailFlowrate;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpbFlowTarget;
        private ReaLTaiizor.Controls.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar2;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar3;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.ForeverToggle toggleAutoControl;
        private System.Windows.Forms.Label label37;
        private ReaLTaiizor.Controls.ForeverToggle toggleRemote;
        private ReaLTaiizor.Controls.ForeverToggle toggleProductEnable;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModuleReboot;
    }
}