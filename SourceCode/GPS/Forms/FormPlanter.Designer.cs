namespace AgOpenGPS.Forms
{
    partial class FormPlanter
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
            this.toggleProductEnable = new ReaLTaiizor.Controls.ForeverToggle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRateAct = new System.Windows.Forms.Label();
            this.lblpbRegulatorTarget = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTargetRate = new System.Windows.Forms.Label();
            this.btnDecPlntrTarRate = new System.Windows.Forms.Button();
            this.btnIncPlntrTarRate = new System.Windows.Forms.Button();
            this.cyberProgressBar3 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.cyberProgressBar4 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.pbRailPressureRpt = new ReaLTaiizor.Controls.CyberProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.pbRailFlowrateTarget = new ReaLTaiizor.Controls.CyberProgressBar();
            this.lblRPMtar = new System.Windows.Forms.Label();
            this.pbRailPressureTarget = new ReaLTaiizor.Controls.CyberProgressBar();
            this.lblpbFlowTarget = new System.Windows.Forms.Label();
            this.pbRailFlowrate = new ReaLTaiizor.Controls.CyberProgressBar();
            this.lblpbPressureTarget = new System.Windows.Forms.Label();
            this.labelpbTargetRate = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pbRateRpt = new ReaLTaiizor.Controls.CyberProgressBar();
            this.cyberProgressBar1 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.cyberProgressBar2 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.pbRateTarget = new ReaLTaiizor.Controls.CyberProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPlanterHealth = new System.Windows.Forms.Panel();
            this.panelPlanterProduct = new System.Windows.Forms.Panel();
            this.btnProduct = new ReaLTaiizor.Controls.Button();
            this.lblPressureAct = new System.Windows.Forms.Label();
            this.lblRegPosAct = new System.Windows.Forms.Label();
            this.lblFlowAct = new System.Windows.Forms.Label();
            this.lblRPMact = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPlanterProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.toggleProductEnable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1263, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 415);
            this.panel1.TabIndex = 0;
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
            this.toggleProductEnable.Location = new System.Drawing.Point(36, 54);
            this.toggleProductEnable.Name = "toggleProductEnable";
            this.toggleProductEnable.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.toggleProductEnable.Size = new System.Drawing.Size(76, 33);
            this.toggleProductEnable.TabIndex = 15;
            this.toggleProductEnable.Text = "foreverToggle1";
            this.toggleProductEnable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toggleProductEnable.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 88);
            this.label1.TabIndex = 16;
            this.label1.Text = "ENABLE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRateAct
            // 
            this.lblRateAct.AutoSize = true;
            this.lblRateAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRateAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateAct.ForeColor = System.Drawing.Color.White;
            this.lblRateAct.Location = new System.Drawing.Point(293, 56);
            this.lblRateAct.Name = "lblRateAct";
            this.lblRateAct.Size = new System.Drawing.Size(32, 13);
            this.lblRateAct.TabIndex = 63;
            this.lblRateAct.Text = "0.00";
            this.lblRateAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblpbRegulatorTarget
            // 
            this.lblpbRegulatorTarget.AutoSize = true;
            this.lblpbRegulatorTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpbRegulatorTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpbRegulatorTarget.ForeColor = System.Drawing.Color.White;
            this.lblpbRegulatorTarget.Location = new System.Drawing.Point(620, 43);
            this.lblpbRegulatorTarget.Name = "lblpbRegulatorTarget";
            this.lblpbRegulatorTarget.Size = new System.Drawing.Size(32, 13);
            this.lblpbRegulatorTarget.TabIndex = 61;
            this.lblpbRegulatorTarget.Text = "0.00";
            this.lblpbRegulatorTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelTargetRate);
            this.panel2.Controls.Add(this.btnDecPlntrTarRate);
            this.panel2.Controls.Add(this.btnIncPlntrTarRate);
            this.panel2.Location = new System.Drawing.Point(28, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 145);
            this.panel2.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 36);
            this.label5.TabIndex = 41;
            this.label5.Text = "TARGET RATE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTargetRate
            // 
            this.labelTargetRate.BackColor = System.Drawing.Color.Black;
            this.labelTargetRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargetRate.ForeColor = System.Drawing.Color.White;
            this.labelTargetRate.Location = new System.Drawing.Point(44, 35);
            this.labelTargetRate.Name = "labelTargetRate";
            this.labelTargetRate.Size = new System.Drawing.Size(113, 45);
            this.labelTargetRate.TabIndex = 36;
            this.labelTargetRate.Text = "0.00";
            this.labelTargetRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDecPlntrTarRate
            // 
            this.btnDecPlntrTarRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDecPlntrTarRate.FlatAppearance.BorderSize = 0;
            this.btnDecPlntrTarRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecPlntrTarRate.Image = global::AgOpenGPS.Properties.Resources.left_arrow;
            this.btnDecPlntrTarRate.Location = new System.Drawing.Point(12, 78);
            this.btnDecPlntrTarRate.Name = "btnDecPlntrTarRate";
            this.btnDecPlntrTarRate.Size = new System.Drawing.Size(58, 59);
            this.btnDecPlntrTarRate.TabIndex = 38;
            this.btnDecPlntrTarRate.UseVisualStyleBackColor = false;
            this.btnDecPlntrTarRate.Click += new System.EventHandler(this.btnDecPlntrTarRate_Click_1);
            // 
            // btnIncPlntrTarRate
            // 
            this.btnIncPlntrTarRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncPlntrTarRate.FlatAppearance.BorderSize = 0;
            this.btnIncPlntrTarRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncPlntrTarRate.Image = global::AgOpenGPS.Properties.Resources.right_arrow;
            this.btnIncPlntrTarRate.Location = new System.Drawing.Point(124, 78);
            this.btnIncPlntrTarRate.Name = "btnIncPlntrTarRate";
            this.btnIncPlntrTarRate.Size = new System.Drawing.Size(58, 59);
            this.btnIncPlntrTarRate.TabIndex = 39;
            this.btnIncPlntrTarRate.UseVisualStyleBackColor = false;
            this.btnIncPlntrTarRate.Click += new System.EventHandler(this.btnIncPlntrTarRate_Click_1);
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
            this.cyberProgressBar3.Location = new System.Drawing.Point(658, 41);
            this.cyberProgressBar3.Maximum = 1000;
            this.cyberProgressBar3.Minimum = 0;
            this.cyberProgressBar3.Name = "cyberProgressBar3";
            this.cyberProgressBar3.PenWidth = 10;
            this.cyberProgressBar3.ProgressText = false;
            this.cyberProgressBar3.RGB = false;
            this.cyberProgressBar3.Rounding = true;
            this.cyberProgressBar3.RoundingInt = 15;
            this.cyberProgressBar3.Size = new System.Drawing.Size(100, 15);
            this.cyberProgressBar3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberProgressBar3.StartDrawingValue = 0;
            this.cyberProgressBar3.TabIndex = 58;
            this.cyberProgressBar3.Tag = "Cyber";
            this.cyberProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberProgressBar3.Timer_RGB = 300;
            this.cyberProgressBar3.Value = 0;
            // 
            // cyberProgressBar4
            // 
            this.cyberProgressBar4.Alpha = 50;
            this.cyberProgressBar4.BackColor = System.Drawing.Color.Transparent;
            this.cyberProgressBar4.Background = true;
            this.cyberProgressBar4.Background_WidthPen = 3F;
            this.cyberProgressBar4.BackgroundPen = true;
            this.cyberProgressBar4.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar4.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar4.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar4.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.cyberProgressBar4.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar4.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberProgressBar4.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar4.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar4.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar4.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar4.ColorValue_Transparency = 200;
            this.cyberProgressBar4.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberProgressBar4.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar4.Lighting = false;
            this.cyberProgressBar4.LinearGradient_Background = false;
            this.cyberProgressBar4.LinearGradient_Value = false;
            this.cyberProgressBar4.LinearGradientPen = false;
            this.cyberProgressBar4.Location = new System.Drawing.Point(658, 57);
            this.cyberProgressBar4.Maximum = 1000;
            this.cyberProgressBar4.Minimum = 0;
            this.cyberProgressBar4.Name = "cyberProgressBar4";
            this.cyberProgressBar4.PenWidth = 10;
            this.cyberProgressBar4.ProgressText = false;
            this.cyberProgressBar4.RGB = false;
            this.cyberProgressBar4.Rounding = true;
            this.cyberProgressBar4.RoundingInt = 15;
            this.cyberProgressBar4.Size = new System.Drawing.Size(100, 15);
            this.cyberProgressBar4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberProgressBar4.StartDrawingValue = 0;
            this.cyberProgressBar4.TabIndex = 57;
            this.cyberProgressBar4.Tag = "Cyber";
            this.cyberProgressBar4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberProgressBar4.Timer_RGB = 300;
            this.cyberProgressBar4.Value = 0;
            // 
            // pbRailPressureRpt
            // 
            this.pbRailPressureRpt.Alpha = 50;
            this.pbRailPressureRpt.BackColor = System.Drawing.Color.Transparent;
            this.pbRailPressureRpt.Background = true;
            this.pbRailPressureRpt.Background_WidthPen = 3F;
            this.pbRailPressureRpt.BackgroundPen = true;
            this.pbRailPressureRpt.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailPressureRpt.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailPressureRpt.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRailPressureRpt.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.pbRailPressureRpt.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailPressureRpt.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.pbRailPressureRpt.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailPressureRpt.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailPressureRpt.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRailPressureRpt.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailPressureRpt.ColorValue_Transparency = 200;
            this.pbRailPressureRpt.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.pbRailPressureRpt.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRailPressureRpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRailPressureRpt.Lighting = false;
            this.pbRailPressureRpt.LinearGradient_Background = false;
            this.pbRailPressureRpt.LinearGradient_Value = false;
            this.pbRailPressureRpt.LinearGradientPen = false;
            this.pbRailPressureRpt.Location = new System.Drawing.Point(497, 54);
            this.pbRailPressureRpt.Maximum = 120;
            this.pbRailPressureRpt.Minimum = 0;
            this.pbRailPressureRpt.Name = "pbRailPressureRpt";
            this.pbRailPressureRpt.PenWidth = 10;
            this.pbRailPressureRpt.ProgressText = false;
            this.pbRailPressureRpt.RGB = false;
            this.pbRailPressureRpt.Rounding = true;
            this.pbRailPressureRpt.RoundingInt = 15;
            this.pbRailPressureRpt.Size = new System.Drawing.Size(100, 15);
            this.pbRailPressureRpt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pbRailPressureRpt.StartDrawingValue = 0;
            this.pbRailPressureRpt.TabIndex = 26;
            this.pbRailPressureRpt.Tag = "Cyber";
            this.pbRailPressureRpt.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pbRailPressureRpt.Timer_RGB = 300;
            this.pbRailPressureRpt.Value = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(615, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 66);
            this.label8.TabIndex = 56;
            this.label8.Text = "REG POS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pbRailFlowrateTarget
            // 
            this.pbRailFlowrateTarget.Alpha = 50;
            this.pbRailFlowrateTarget.BackColor = System.Drawing.Color.Transparent;
            this.pbRailFlowrateTarget.Background = true;
            this.pbRailFlowrateTarget.Background_WidthPen = 3F;
            this.pbRailFlowrateTarget.BackgroundPen = true;
            this.pbRailFlowrateTarget.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailFlowrateTarget.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailFlowrateTarget.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRailFlowrateTarget.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.pbRailFlowrateTarget.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailFlowrateTarget.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.pbRailFlowrateTarget.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailFlowrateTarget.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailFlowrateTarget.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRailFlowrateTarget.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailFlowrateTarget.ColorValue_Transparency = 200;
            this.pbRailFlowrateTarget.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.pbRailFlowrateTarget.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRailFlowrateTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRailFlowrateTarget.Lighting = false;
            this.pbRailFlowrateTarget.LinearGradient_Background = false;
            this.pbRailFlowrateTarget.LinearGradient_Value = false;
            this.pbRailFlowrateTarget.LinearGradientPen = false;
            this.pbRailFlowrateTarget.Location = new System.Drawing.Point(847, 42);
            this.pbRailFlowrateTarget.Maximum = 1000;
            this.pbRailFlowrateTarget.Minimum = 0;
            this.pbRailFlowrateTarget.Name = "pbRailFlowrateTarget";
            this.pbRailFlowrateTarget.PenWidth = 10;
            this.pbRailFlowrateTarget.ProgressText = false;
            this.pbRailFlowrateTarget.RGB = false;
            this.pbRailFlowrateTarget.Rounding = true;
            this.pbRailFlowrateTarget.RoundingInt = 15;
            this.pbRailFlowrateTarget.Size = new System.Drawing.Size(82, 15);
            this.pbRailFlowrateTarget.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pbRailFlowrateTarget.StartDrawingValue = 0;
            this.pbRailFlowrateTarget.TabIndex = 27;
            this.pbRailFlowrateTarget.Tag = "Cyber";
            this.pbRailFlowrateTarget.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pbRailFlowrateTarget.Timer_RGB = 300;
            this.pbRailFlowrateTarget.Value = 0;
            // 
            // lblRPMtar
            // 
            this.lblRPMtar.AutoSize = true;
            this.lblRPMtar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRPMtar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPMtar.ForeColor = System.Drawing.Color.White;
            this.lblRPMtar.Location = new System.Drawing.Point(958, 42);
            this.lblRPMtar.Name = "lblRPMtar";
            this.lblRPMtar.Size = new System.Drawing.Size(32, 13);
            this.lblRPMtar.TabIndex = 55;
            this.lblRPMtar.Text = "0.00";
            this.lblRPMtar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbRailPressureTarget
            // 
            this.pbRailPressureTarget.Alpha = 50;
            this.pbRailPressureTarget.BackColor = System.Drawing.Color.Transparent;
            this.pbRailPressureTarget.Background = true;
            this.pbRailPressureTarget.Background_WidthPen = 3F;
            this.pbRailPressureTarget.BackgroundPen = true;
            this.pbRailPressureTarget.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailPressureTarget.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailPressureTarget.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRailPressureTarget.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.pbRailPressureTarget.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailPressureTarget.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.pbRailPressureTarget.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailPressureTarget.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRailPressureTarget.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRailPressureTarget.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRailPressureTarget.ColorValue_Transparency = 200;
            this.pbRailPressureTarget.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.pbRailPressureTarget.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRailPressureTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRailPressureTarget.Lighting = false;
            this.pbRailPressureTarget.LinearGradient_Background = false;
            this.pbRailPressureTarget.LinearGradient_Value = false;
            this.pbRailPressureTarget.LinearGradientPen = false;
            this.pbRailPressureTarget.Location = new System.Drawing.Point(497, 38);
            this.pbRailPressureTarget.Maximum = 120;
            this.pbRailPressureTarget.Minimum = 0;
            this.pbRailPressureTarget.Name = "pbRailPressureTarget";
            this.pbRailPressureTarget.PenWidth = 10;
            this.pbRailPressureTarget.ProgressText = false;
            this.pbRailPressureTarget.RGB = false;
            this.pbRailPressureTarget.Rounding = true;
            this.pbRailPressureTarget.RoundingInt = 15;
            this.pbRailPressureTarget.Size = new System.Drawing.Size(100, 15);
            this.pbRailPressureTarget.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pbRailPressureTarget.StartDrawingValue = 0;
            this.pbRailPressureTarget.TabIndex = 27;
            this.pbRailPressureTarget.Tag = "Cyber";
            this.pbRailPressureTarget.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pbRailPressureTarget.Timer_RGB = 300;
            this.pbRailPressureTarget.Value = 0;
            // 
            // lblpbFlowTarget
            // 
            this.lblpbFlowTarget.AutoSize = true;
            this.lblpbFlowTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpbFlowTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpbFlowTarget.ForeColor = System.Drawing.Color.White;
            this.lblpbFlowTarget.Location = new System.Drawing.Point(798, 44);
            this.lblpbFlowTarget.Name = "lblpbFlowTarget";
            this.lblpbFlowTarget.Size = new System.Drawing.Size(32, 13);
            this.lblpbFlowTarget.TabIndex = 54;
            this.lblpbFlowTarget.Text = "0.00";
            this.lblpbFlowTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.pbRailFlowrate.Location = new System.Drawing.Point(847, 58);
            this.pbRailFlowrate.Maximum = 10000;
            this.pbRailFlowrate.Minimum = 0;
            this.pbRailFlowrate.Name = "pbRailFlowrate";
            this.pbRailFlowrate.PenWidth = 10;
            this.pbRailFlowrate.ProgressText = false;
            this.pbRailFlowrate.RGB = false;
            this.pbRailFlowrate.Rounding = true;
            this.pbRailFlowrate.RoundingInt = 15;
            this.pbRailFlowrate.Size = new System.Drawing.Size(82, 15);
            this.pbRailFlowrate.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pbRailFlowrate.StartDrawingValue = 0;
            this.pbRailFlowrate.TabIndex = 28;
            this.pbRailFlowrate.Tag = "Cyber";
            this.pbRailFlowrate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pbRailFlowrate.Timer_RGB = 300;
            this.pbRailFlowrate.Value = 0;
            // 
            // lblpbPressureTarget
            // 
            this.lblpbPressureTarget.AutoSize = true;
            this.lblpbPressureTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpbPressureTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpbPressureTarget.ForeColor = System.Drawing.Color.White;
            this.lblpbPressureTarget.Location = new System.Drawing.Point(459, 40);
            this.lblpbPressureTarget.Name = "lblpbPressureTarget";
            this.lblpbPressureTarget.Size = new System.Drawing.Size(32, 13);
            this.lblpbPressureTarget.TabIndex = 53;
            this.lblpbPressureTarget.Text = "0.00";
            this.lblpbPressureTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelpbTargetRate
            // 
            this.labelpbTargetRate.AutoSize = true;
            this.labelpbTargetRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelpbTargetRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpbTargetRate.ForeColor = System.Drawing.Color.White;
            this.labelpbTargetRate.Location = new System.Drawing.Point(293, 37);
            this.labelpbTargetRate.Name = "labelpbTargetRate";
            this.labelpbTargetRate.Size = new System.Drawing.Size(32, 13);
            this.labelpbTargetRate.TabIndex = 52;
            this.labelpbTargetRate.Text = "0.00";
            this.labelpbTargetRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(251, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "ACT.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(251, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "TAR.";
            // 
            // pbRateRpt
            // 
            this.pbRateRpt.Alpha = 50;
            this.pbRateRpt.BackColor = System.Drawing.Color.Transparent;
            this.pbRateRpt.Background = true;
            this.pbRateRpt.Background_WidthPen = 3F;
            this.pbRateRpt.BackgroundPen = true;
            this.pbRateRpt.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRateRpt.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRateRpt.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRateRpt.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.pbRateRpt.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRateRpt.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.pbRateRpt.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRateRpt.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRateRpt.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRateRpt.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRateRpt.ColorValue_Transparency = 200;
            this.pbRateRpt.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.pbRateRpt.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRateRpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRateRpt.Lighting = false;
            this.pbRateRpt.LinearGradient_Background = false;
            this.pbRateRpt.LinearGradient_Value = false;
            this.pbRateRpt.LinearGradientPen = false;
            this.pbRateRpt.Location = new System.Drawing.Point(331, 54);
            this.pbRateRpt.Maximum = 1000;
            this.pbRateRpt.Minimum = 0;
            this.pbRateRpt.Name = "pbRateRpt";
            this.pbRateRpt.PenWidth = 10;
            this.pbRateRpt.ProgressText = false;
            this.pbRateRpt.RGB = false;
            this.pbRateRpt.Rounding = true;
            this.pbRateRpt.RoundingInt = 15;
            this.pbRateRpt.Size = new System.Drawing.Size(107, 15);
            this.pbRateRpt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pbRateRpt.StartDrawingValue = 0;
            this.pbRateRpt.TabIndex = 43;
            this.pbRateRpt.Tag = "Cyber";
            this.pbRateRpt.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pbRateRpt.Timer_RGB = 300;
            this.pbRateRpt.Value = 0;
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
            this.cyberProgressBar1.Location = new System.Drawing.Point(996, 40);
            this.cyberProgressBar1.Maximum = 1000;
            this.cyberProgressBar1.Minimum = 0;
            this.cyberProgressBar1.Name = "cyberProgressBar1";
            this.cyberProgressBar1.PenWidth = 10;
            this.cyberProgressBar1.ProgressText = false;
            this.cyberProgressBar1.RGB = false;
            this.cyberProgressBar1.Rounding = true;
            this.cyberProgressBar1.RoundingInt = 15;
            this.cyberProgressBar1.Size = new System.Drawing.Size(100, 15);
            this.cyberProgressBar1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberProgressBar1.StartDrawingValue = 0;
            this.cyberProgressBar1.TabIndex = 49;
            this.cyberProgressBar1.Tag = "Cyber";
            this.cyberProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberProgressBar1.Timer_RGB = 300;
            this.cyberProgressBar1.Value = 0;
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
            this.cyberProgressBar2.Location = new System.Drawing.Point(996, 56);
            this.cyberProgressBar2.Maximum = 1000;
            this.cyberProgressBar2.Minimum = 0;
            this.cyberProgressBar2.Name = "cyberProgressBar2";
            this.cyberProgressBar2.PenWidth = 10;
            this.cyberProgressBar2.ProgressText = false;
            this.cyberProgressBar2.RGB = false;
            this.cyberProgressBar2.Rounding = true;
            this.cyberProgressBar2.RoundingInt = 15;
            this.cyberProgressBar2.Size = new System.Drawing.Size(100, 15);
            this.cyberProgressBar2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberProgressBar2.StartDrawingValue = 0;
            this.cyberProgressBar2.TabIndex = 48;
            this.cyberProgressBar2.Tag = "Cyber";
            this.cyberProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberProgressBar2.Timer_RGB = 300;
            this.cyberProgressBar2.Value = 0;
            // 
            // pbRateTarget
            // 
            this.pbRateTarget.Alpha = 50;
            this.pbRateTarget.BackColor = System.Drawing.Color.Transparent;
            this.pbRateTarget.Background = true;
            this.pbRateTarget.Background_WidthPen = 3F;
            this.pbRateTarget.BackgroundPen = true;
            this.pbRateTarget.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRateTarget.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRateTarget.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRateTarget.ColorBackground_Pen = System.Drawing.Color.WhiteSmoke;
            this.pbRateTarget.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRateTarget.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.pbRateTarget.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRateTarget.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.pbRateTarget.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.pbRateTarget.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.pbRateTarget.ColorValue_Transparency = 200;
            this.pbRateTarget.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.pbRateTarget.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRateTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRateTarget.Lighting = false;
            this.pbRateTarget.LinearGradient_Background = false;
            this.pbRateTarget.LinearGradient_Value = false;
            this.pbRateTarget.LinearGradientPen = false;
            this.pbRateTarget.Location = new System.Drawing.Point(331, 37);
            this.pbRateTarget.Maximum = 3000;
            this.pbRateTarget.Minimum = 0;
            this.pbRateTarget.Name = "pbRateTarget";
            this.pbRateTarget.PenWidth = 10;
            this.pbRateTarget.ProgressText = false;
            this.pbRateTarget.RGB = false;
            this.pbRateTarget.Rounding = true;
            this.pbRateTarget.RoundingInt = 15;
            this.pbRateTarget.Size = new System.Drawing.Size(107, 15);
            this.pbRateTarget.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pbRateTarget.StartDrawingValue = 0;
            this.pbRateTarget.TabIndex = 44;
            this.pbRateTarget.Tag = "Cyber";
            this.pbRateTarget.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pbRateTarget.Timer_RGB = 300;
            this.pbRateTarget.Value = 0;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(782, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 66);
            this.label13.TabIndex = 15;
            this.label13.Text = "FLOW";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label23.Location = new System.Drawing.Point(244, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(203, 67);
            this.label23.TabIndex = 42;
            this.label23.Text = "RATE";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(453, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 66);
            this.label12.TabIndex = 14;
            this.label12.Text = "PRESSURE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(948, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 67);
            this.label4.TabIndex = 47;
            this.label4.Text = "PUMP CMD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPlanterHealth
            // 
            this.panelPlanterHealth.Location = new System.Drawing.Point(12, 12);
            this.panelPlanterHealth.Name = "panelPlanterHealth";
            this.panelPlanterHealth.Size = new System.Drawing.Size(1143, 170);
            this.panelPlanterHealth.TabIndex = 0;
            this.panelPlanterHealth.Visible = false;
            // 
            // panelPlanterProduct
            // 
            this.panelPlanterProduct.Controls.Add(this.lblRPMact);
            this.panelPlanterProduct.Controls.Add(this.lblFlowAct);
            this.panelPlanterProduct.Controls.Add(this.lblRegPosAct);
            this.panelPlanterProduct.Controls.Add(this.lblPressureAct);
            this.panelPlanterProduct.Controls.Add(this.lblRateAct);
            this.panelPlanterProduct.Controls.Add(this.lblpbRegulatorTarget);
            this.panelPlanterProduct.Controls.Add(this.panel2);
            this.panelPlanterProduct.Controls.Add(this.cyberProgressBar3);
            this.panelPlanterProduct.Controls.Add(this.cyberProgressBar4);
            this.panelPlanterProduct.Controls.Add(this.pbRailPressureRpt);
            this.panelPlanterProduct.Controls.Add(this.pbRailFlowrateTarget);
            this.panelPlanterProduct.Controls.Add(this.lblRPMtar);
            this.panelPlanterProduct.Controls.Add(this.pbRateTarget);
            this.panelPlanterProduct.Controls.Add(this.pbRailPressureTarget);
            this.panelPlanterProduct.Controls.Add(this.cyberProgressBar2);
            this.panelPlanterProduct.Controls.Add(this.lblpbFlowTarget);
            this.panelPlanterProduct.Controls.Add(this.cyberProgressBar1);
            this.panelPlanterProduct.Controls.Add(this.pbRailFlowrate);
            this.panelPlanterProduct.Controls.Add(this.pbRateRpt);
            this.panelPlanterProduct.Controls.Add(this.lblpbPressureTarget);
            this.panelPlanterProduct.Controls.Add(this.label22);
            this.panelPlanterProduct.Controls.Add(this.labelpbTargetRate);
            this.panelPlanterProduct.Controls.Add(this.label21);
            this.panelPlanterProduct.Controls.Add(this.label23);
            this.panelPlanterProduct.Controls.Add(this.label12);
            this.panelPlanterProduct.Controls.Add(this.label8);
            this.panelPlanterProduct.Controls.Add(this.label13);
            this.panelPlanterProduct.Controls.Add(this.label4);
            this.panelPlanterProduct.Location = new System.Drawing.Point(12, 188);
            this.panelPlanterProduct.Name = "panelPlanterProduct";
            this.panelPlanterProduct.Size = new System.Drawing.Size(1143, 172);
            this.panelPlanterProduct.TabIndex = 64;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnProduct.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProduct.Image = null;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnProduct.Location = new System.Drawing.Point(1161, 15);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnProduct.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnProduct.Size = new System.Drawing.Size(96, 50);
            this.btnProduct.TabIndex = 65;
            this.btnProduct.Text = "Toggle";
            this.btnProduct.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblPressureAct
            // 
            this.lblPressureAct.AutoSize = true;
            this.lblPressureAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPressureAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressureAct.ForeColor = System.Drawing.Color.White;
            this.lblPressureAct.Location = new System.Drawing.Point(459, 56);
            this.lblPressureAct.Name = "lblPressureAct";
            this.lblPressureAct.Size = new System.Drawing.Size(32, 13);
            this.lblPressureAct.TabIndex = 64;
            this.lblPressureAct.Text = "0.00";
            this.lblPressureAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegPosAct
            // 
            this.lblRegPosAct.AutoSize = true;
            this.lblRegPosAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRegPosAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPosAct.ForeColor = System.Drawing.Color.White;
            this.lblRegPosAct.Location = new System.Drawing.Point(620, 60);
            this.lblRegPosAct.Name = "lblRegPosAct";
            this.lblRegPosAct.Size = new System.Drawing.Size(32, 13);
            this.lblRegPosAct.TabIndex = 65;
            this.lblRegPosAct.Text = "0.00";
            this.lblRegPosAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlowAct
            // 
            this.lblFlowAct.AutoSize = true;
            this.lblFlowAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFlowAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowAct.ForeColor = System.Drawing.Color.White;
            this.lblFlowAct.Location = new System.Drawing.Point(798, 60);
            this.lblFlowAct.Name = "lblFlowAct";
            this.lblFlowAct.Size = new System.Drawing.Size(32, 13);
            this.lblFlowAct.TabIndex = 66;
            this.lblFlowAct.Text = "0.00";
            this.lblFlowAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRPMact
            // 
            this.lblRPMact.AutoSize = true;
            this.lblRPMact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRPMact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPMact.ForeColor = System.Drawing.Color.White;
            this.lblRPMact.Location = new System.Drawing.Point(958, 58);
            this.lblRPMact.Name = "lblRPMact";
            this.lblRPMact.Size = new System.Drawing.Size(32, 13);
            this.lblRPMact.TabIndex = 67;
            this.lblRPMact.Text = "0.00";
            this.lblRPMact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormPlanter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1421, 415);
            this.Controls.Add(this.panelPlanterProduct);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPlanterHealth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlanter";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelPlanterProduct.ResumeLayout(false);
            this.panelPlanterProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.ForeverToggle toggleProductEnable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRPMtar;
        private System.Windows.Forms.Button btnIncPlntrTarRate;
        private System.Windows.Forms.Label lblpbFlowTarget;
        private System.Windows.Forms.Button btnDecPlntrTarRate;
        private System.Windows.Forms.Label lblpbPressureTarget;
        private System.Windows.Forms.Label labelTargetRate;
        private System.Windows.Forms.Label labelpbTargetRate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar1;
        private ReaLTaiizor.Controls.CyberProgressBar pbRateTarget;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar2;
        private ReaLTaiizor.Controls.CyberProgressBar pbRateRpt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private ReaLTaiizor.Controls.CyberProgressBar pbRailFlowrate;
        private ReaLTaiizor.Controls.CyberProgressBar pbRailPressureTarget;
        private ReaLTaiizor.Controls.CyberProgressBar pbRailFlowrateTarget;
        private ReaLTaiizor.Controls.CyberProgressBar pbRailPressureRpt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblpbRegulatorTarget;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar3;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelPlanterHealth;
        private System.Windows.Forms.Label lblRateAct;
        private System.Windows.Forms.Panel panelPlanterProduct;
        private ReaLTaiizor.Controls.Button btnProduct;
        private System.Windows.Forms.Label lblRPMact;
        private System.Windows.Forms.Label lblFlowAct;
        private System.Windows.Forms.Label lblRegPosAct;
        private System.Windows.Forms.Label lblPressureAct;
    }
}