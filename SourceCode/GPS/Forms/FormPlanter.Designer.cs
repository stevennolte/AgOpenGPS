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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toggleProductEnable = new ReaLTaiizor.Controls.ForeverToggle();
            this.btnProduct = new ReaLTaiizor.Controls.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRateAct = new System.Windows.Forms.Label();
            this.lblpbRegulatorTarget = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pbRateRpt = new ReaLTaiizor.Controls.CyberProgressBar();
            this.cyberProgressBar1 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.cyberProgressBar2 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.pbRateTarget = new ReaLTaiizor.Controls.CyberProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPlanterHealth = new System.Windows.Forms.Panel();
            this.btnModuleReboot = new System.Windows.Forms.Button();
            this.panelPlanterProduct = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.barChartPlanter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIncPlntrTarRate = new System.Windows.Forms.Button();
            this.btnDecPlntrTarRate = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPressureAct = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegPosAct = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRPMact = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFlowAct = new System.Windows.Forms.Label();
            this.formPlanterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panelPlanterHealth.SuspendLayout();
            this.panelPlanterProduct.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChartPlanter)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formPlanterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.toggleProductEnable);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1263, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 660);
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
            this.btnProduct.Location = new System.Drawing.Point(23, 115);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnProduct.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnProduct.Size = new System.Drawing.Size(109, 50);
            this.btnProduct.TabIndex = 65;
            this.btnProduct.Text = "Toggle";
            this.btnProduct.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
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
            this.lblRateAct.BackColor = System.Drawing.Color.Transparent;
            this.lblRateAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRateAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateAct.ForeColor = System.Drawing.Color.White;
            this.lblRateAct.Location = new System.Drawing.Point(3, 50);
            this.lblRateAct.Name = "lblRateAct";
            this.lblRateAct.Size = new System.Drawing.Size(59, 24);
            this.lblRateAct.TabIndex = 63;
            this.lblRateAct.Text = "0.00";
            this.lblRateAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblpbRegulatorTarget
            // 
            this.lblpbRegulatorTarget.AutoSize = true;
            this.lblpbRegulatorTarget.BackColor = System.Drawing.Color.Transparent;
            this.lblpbRegulatorTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblpbRegulatorTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpbRegulatorTarget.ForeColor = System.Drawing.Color.White;
            this.lblpbRegulatorTarget.Location = new System.Drawing.Point(3, 25);
            this.lblpbRegulatorTarget.Name = "lblpbRegulatorTarget";
            this.lblpbRegulatorTarget.Size = new System.Drawing.Size(59, 25);
            this.lblpbRegulatorTarget.TabIndex = 61;
            this.lblpbRegulatorTarget.Text = "0.00";
            this.lblpbRegulatorTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "TARGET RATE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cyberProgressBar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cyberProgressBar3.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar3.Lighting = false;
            this.cyberProgressBar3.LinearGradient_Background = false;
            this.cyberProgressBar3.LinearGradient_Value = false;
            this.cyberProgressBar3.LinearGradientPen = false;
            this.cyberProgressBar3.Location = new System.Drawing.Point(68, 28);
            this.cyberProgressBar3.Maximum = 1000;
            this.cyberProgressBar3.Minimum = 0;
            this.cyberProgressBar3.Name = "cyberProgressBar3";
            this.cyberProgressBar3.PenWidth = 10;
            this.cyberProgressBar3.ProgressText = false;
            this.cyberProgressBar3.RGB = false;
            this.cyberProgressBar3.Rounding = true;
            this.cyberProgressBar3.RoundingInt = 15;
            this.cyberProgressBar3.Size = new System.Drawing.Size(126, 19);
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
            this.cyberProgressBar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cyberProgressBar4.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar4.Lighting = false;
            this.cyberProgressBar4.LinearGradient_Background = false;
            this.cyberProgressBar4.LinearGradient_Value = false;
            this.cyberProgressBar4.LinearGradientPen = false;
            this.cyberProgressBar4.Location = new System.Drawing.Point(68, 53);
            this.cyberProgressBar4.Maximum = 1000;
            this.cyberProgressBar4.Minimum = 0;
            this.cyberProgressBar4.Name = "cyberProgressBar4";
            this.cyberProgressBar4.PenWidth = 10;
            this.cyberProgressBar4.ProgressText = false;
            this.cyberProgressBar4.RGB = false;
            this.cyberProgressBar4.Rounding = true;
            this.cyberProgressBar4.RoundingInt = 15;
            this.cyberProgressBar4.Size = new System.Drawing.Size(126, 18);
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
            this.pbRailPressureRpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRailPressureRpt.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRailPressureRpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRailPressureRpt.Lighting = false;
            this.pbRailPressureRpt.LinearGradient_Background = false;
            this.pbRailPressureRpt.LinearGradient_Value = false;
            this.pbRailPressureRpt.LinearGradientPen = false;
            this.pbRailPressureRpt.Location = new System.Drawing.Point(68, 53);
            this.pbRailPressureRpt.Maximum = 120;
            this.pbRailPressureRpt.Minimum = 0;
            this.pbRailPressureRpt.Name = "pbRailPressureRpt";
            this.pbRailPressureRpt.PenWidth = 10;
            this.pbRailPressureRpt.ProgressText = false;
            this.pbRailPressureRpt.RGB = false;
            this.pbRailPressureRpt.Rounding = true;
            this.pbRailPressureRpt.RoundingInt = 15;
            this.pbRailPressureRpt.Size = new System.Drawing.Size(125, 18);
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
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 25);
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
            this.pbRailFlowrateTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRailFlowrateTarget.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRailFlowrateTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRailFlowrateTarget.Lighting = false;
            this.pbRailFlowrateTarget.LinearGradient_Background = false;
            this.pbRailFlowrateTarget.LinearGradient_Value = false;
            this.pbRailFlowrateTarget.LinearGradientPen = false;
            this.pbRailFlowrateTarget.Location = new System.Drawing.Point(58, 26);
            this.pbRailFlowrateTarget.Maximum = 1000;
            this.pbRailFlowrateTarget.Minimum = 0;
            this.pbRailFlowrateTarget.Name = "pbRailFlowrateTarget";
            this.pbRailFlowrateTarget.PenWidth = 10;
            this.pbRailFlowrateTarget.ProgressText = false;
            this.pbRailFlowrateTarget.RGB = false;
            this.pbRailFlowrateTarget.Rounding = true;
            this.pbRailFlowrateTarget.RoundingInt = 15;
            this.pbRailFlowrateTarget.Size = new System.Drawing.Size(136, 19);
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
            this.lblRPMtar.BackColor = System.Drawing.Color.Transparent;
            this.lblRPMtar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRPMtar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPMtar.ForeColor = System.Drawing.Color.White;
            this.lblRPMtar.Location = new System.Drawing.Point(3, 24);
            this.lblRPMtar.Name = "lblRPMtar";
            this.lblRPMtar.Size = new System.Drawing.Size(38, 26);
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
            this.pbRailPressureTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRailPressureTarget.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRailPressureTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRailPressureTarget.Lighting = false;
            this.pbRailPressureTarget.LinearGradient_Background = false;
            this.pbRailPressureTarget.LinearGradient_Value = false;
            this.pbRailPressureTarget.LinearGradientPen = false;
            this.pbRailPressureTarget.Location = new System.Drawing.Point(68, 28);
            this.pbRailPressureTarget.Maximum = 120;
            this.pbRailPressureTarget.Minimum = 0;
            this.pbRailPressureTarget.Name = "pbRailPressureTarget";
            this.pbRailPressureTarget.PenWidth = 10;
            this.pbRailPressureTarget.ProgressText = false;
            this.pbRailPressureTarget.RGB = false;
            this.pbRailPressureTarget.Rounding = true;
            this.pbRailPressureTarget.RoundingInt = 15;
            this.pbRailPressureTarget.Size = new System.Drawing.Size(125, 19);
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
            this.lblpbFlowTarget.BackColor = System.Drawing.Color.Transparent;
            this.lblpbFlowTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblpbFlowTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpbFlowTarget.ForeColor = System.Drawing.Color.White;
            this.lblpbFlowTarget.Location = new System.Drawing.Point(3, 23);
            this.lblpbFlowTarget.Name = "lblpbFlowTarget";
            this.lblpbFlowTarget.Size = new System.Drawing.Size(49, 25);
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
            this.pbRailFlowrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRailFlowrate.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRailFlowrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRailFlowrate.Lighting = false;
            this.pbRailFlowrate.LinearGradient_Background = false;
            this.pbRailFlowrate.LinearGradient_Value = false;
            this.pbRailFlowrate.LinearGradientPen = false;
            this.pbRailFlowrate.Location = new System.Drawing.Point(58, 51);
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
            this.pbRailFlowrate.TabIndex = 28;
            this.pbRailFlowrate.Tag = "Cyber";
            this.pbRailFlowrate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pbRailFlowrate.Timer_RGB = 300;
            this.pbRailFlowrate.Value = 0;
            // 
            // lblpbPressureTarget
            // 
            this.lblpbPressureTarget.AutoSize = true;
            this.lblpbPressureTarget.BackColor = System.Drawing.Color.Transparent;
            this.lblpbPressureTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblpbPressureTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpbPressureTarget.ForeColor = System.Drawing.Color.White;
            this.lblpbPressureTarget.Location = new System.Drawing.Point(3, 25);
            this.lblpbPressureTarget.Name = "lblpbPressureTarget";
            this.lblpbPressureTarget.Size = new System.Drawing.Size(59, 25);
            this.lblpbPressureTarget.TabIndex = 53;
            this.lblpbPressureTarget.Text = "0.00";
            this.lblpbPressureTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelpbTargetRate
            // 
            this.labelpbTargetRate.AutoSize = true;
            this.labelpbTargetRate.BackColor = System.Drawing.Color.Transparent;
            this.labelpbTargetRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelpbTargetRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpbTargetRate.ForeColor = System.Drawing.Color.White;
            this.labelpbTargetRate.Location = new System.Drawing.Point(3, 25);
            this.labelpbTargetRate.Name = "labelpbTargetRate";
            this.labelpbTargetRate.Size = new System.Drawing.Size(59, 25);
            this.labelpbTargetRate.TabIndex = 52;
            this.labelpbTargetRate.Text = "0.00";
            this.labelpbTargetRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.pbRateRpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRateRpt.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRateRpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRateRpt.Lighting = false;
            this.pbRateRpt.LinearGradient_Background = false;
            this.pbRateRpt.LinearGradient_Value = false;
            this.pbRateRpt.LinearGradientPen = false;
            this.pbRateRpt.Location = new System.Drawing.Point(68, 53);
            this.pbRateRpt.Maximum = 1000;
            this.pbRateRpt.Minimum = 0;
            this.pbRateRpt.Name = "pbRateRpt";
            this.pbRateRpt.PenWidth = 10;
            this.pbRateRpt.ProgressText = false;
            this.pbRateRpt.RGB = false;
            this.pbRateRpt.Rounding = true;
            this.pbRateRpt.RoundingInt = 15;
            this.pbRateRpt.Size = new System.Drawing.Size(125, 18);
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
            this.cyberProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cyberProgressBar1.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar1.Lighting = false;
            this.cyberProgressBar1.LinearGradient_Background = false;
            this.cyberProgressBar1.LinearGradient_Value = false;
            this.cyberProgressBar1.LinearGradientPen = false;
            this.cyberProgressBar1.Location = new System.Drawing.Point(47, 27);
            this.cyberProgressBar1.Maximum = 1000;
            this.cyberProgressBar1.Minimum = 0;
            this.cyberProgressBar1.Name = "cyberProgressBar1";
            this.cyberProgressBar1.PenWidth = 10;
            this.cyberProgressBar1.ProgressText = false;
            this.cyberProgressBar1.RGB = false;
            this.cyberProgressBar1.Rounding = true;
            this.cyberProgressBar1.RoundingInt = 15;
            this.cyberProgressBar1.Size = new System.Drawing.Size(150, 20);
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
            this.cyberProgressBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cyberProgressBar2.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar2.Lighting = false;
            this.cyberProgressBar2.LinearGradient_Background = false;
            this.cyberProgressBar2.LinearGradient_Value = false;
            this.cyberProgressBar2.LinearGradientPen = false;
            this.cyberProgressBar2.Location = new System.Drawing.Point(47, 53);
            this.cyberProgressBar2.Maximum = 1000;
            this.cyberProgressBar2.Minimum = 0;
            this.cyberProgressBar2.Name = "cyberProgressBar2";
            this.cyberProgressBar2.PenWidth = 10;
            this.cyberProgressBar2.ProgressText = false;
            this.cyberProgressBar2.RGB = false;
            this.cyberProgressBar2.Rounding = true;
            this.cyberProgressBar2.RoundingInt = 15;
            this.cyberProgressBar2.Size = new System.Drawing.Size(150, 18);
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
            this.pbRateTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRateTarget.Font = new System.Drawing.Font("Arial", 11F);
            this.pbRateTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pbRateTarget.Lighting = false;
            this.pbRateTarget.LinearGradient_Background = false;
            this.pbRateTarget.LinearGradient_Value = false;
            this.pbRateTarget.LinearGradientPen = false;
            this.pbRateTarget.Location = new System.Drawing.Point(68, 28);
            this.pbRateTarget.Maximum = 3000;
            this.pbRateTarget.Minimum = 0;
            this.pbRateTarget.Name = "pbRateTarget";
            this.pbRateTarget.PenWidth = 10;
            this.pbRateTarget.ProgressText = false;
            this.pbRateTarget.RGB = false;
            this.pbRateTarget.Rounding = true;
            this.pbRateTarget.RoundingInt = 15;
            this.pbRateTarget.Size = new System.Drawing.Size(125, 19);
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
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.SetColumnSpan(this.label13, 2);
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "FLOW";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel6.SetColumnSpan(this.label23, 2);
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label23.Location = new System.Drawing.Point(3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(190, 25);
            this.label23.TabIndex = 42;
            this.label23.Text = "RATE";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.SetColumnSpan(this.label12, 2);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "PRESSURE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "PUMP CMD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPlanterHealth
            // 
            this.panelPlanterHealth.BackColor = System.Drawing.Color.Transparent;
            this.panelPlanterHealth.Controls.Add(this.btnModuleReboot);
            this.panelPlanterHealth.Location = new System.Drawing.Point(12, 12);
            this.panelPlanterHealth.Name = "panelPlanterHealth";
            this.panelPlanterHealth.Size = new System.Drawing.Size(1219, 170);
            this.panelPlanterHealth.TabIndex = 0;
            this.panelPlanterHealth.Visible = false;
            // 
            // btnModuleReboot
            // 
            this.btnModuleReboot.AutoSize = true;
            this.btnModuleReboot.BackgroundImage = global::AgOpenGPS.Properties.Resources.Reboot;
            this.btnModuleReboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModuleReboot.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModuleReboot.Location = new System.Drawing.Point(1073, 0);
            this.btnModuleReboot.Name = "btnModuleReboot";
            this.btnModuleReboot.Size = new System.Drawing.Size(146, 170);
            this.btnModuleReboot.TabIndex = 0;
            this.btnModuleReboot.UseVisualStyleBackColor = true;
            this.btnModuleReboot.Click += new System.EventHandler(this.btnModuleReboot_Click);
            // 
            // panelPlanterProduct
            // 
            this.panelPlanterProduct.Controls.Add(this.tableLayoutPanel1);
            this.panelPlanterProduct.Location = new System.Drawing.Point(12, 188);
            this.panelPlanterProduct.Name = "panelPlanterProduct";
            this.panelPlanterProduct.Size = new System.Drawing.Size(1219, 220);
            this.panelPlanterProduct.TabIndex = 64;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.62651F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.62651F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.barChartPlanter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.81818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.18182F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1219, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // barChartPlanter
            // 
            this.barChartPlanter.BackColor = System.Drawing.Color.Transparent;
            this.barChartPlanter.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.barChartPlanter.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.barChartPlanter, 6);
            this.barChartPlanter.DataSource = this.formPlanterBindingSource;
            this.barChartPlanter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barChartPlanter.Location = new System.Drawing.Point(3, 83);
            this.barChartPlanter.Name = "barChartPlanter";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series2";
            series1.XValueMember = "ROW";
            series1.YValueMembers = "FREQ_RPT";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series3";
            series2.XValueMember = "ROW";
            series2.YValueMembers = "CMD_DUTY";
            this.barChartPlanter.Series.Add(series1);
            this.barChartPlanter.Series.Add(series2);
            this.barChartPlanter.Size = new System.Drawing.Size(1213, 134);
            this.barChartPlanter.TabIndex = 68;
            this.barChartPlanter.Text = "chart1";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.06383F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.93617F));
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnIncPlntrTarRate, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnDecPlntrTarRate, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(197, 74);
            this.tableLayoutPanel7.TabIndex = 65;
            // 
            // btnIncPlntrTarRate
            // 
            this.btnIncPlntrTarRate.BackColor = System.Drawing.Color.Transparent;
            this.btnIncPlntrTarRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncPlntrTarRate.FlatAppearance.BorderSize = 0;
            this.btnIncPlntrTarRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncPlntrTarRate.Image = global::AgOpenGPS.Properties.Resources.right_arrow;
            this.btnIncPlntrTarRate.Location = new System.Drawing.Point(103, 22);
            this.btnIncPlntrTarRate.Name = "btnIncPlntrTarRate";
            this.tableLayoutPanel7.SetRowSpan(this.btnIncPlntrTarRate, 2);
            this.btnIncPlntrTarRate.Size = new System.Drawing.Size(91, 49);
            this.btnIncPlntrTarRate.TabIndex = 39;
            this.btnIncPlntrTarRate.UseVisualStyleBackColor = false;
            this.btnIncPlntrTarRate.Click += new System.EventHandler(this.btnIncPlntrTarRate_Click_1);
            // 
            // btnDecPlntrTarRate
            // 
            this.btnDecPlntrTarRate.BackColor = System.Drawing.Color.Transparent;
            this.btnDecPlntrTarRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecPlntrTarRate.FlatAppearance.BorderSize = 0;
            this.btnDecPlntrTarRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecPlntrTarRate.Image = global::AgOpenGPS.Properties.Resources.left_arrow;
            this.btnDecPlntrTarRate.Location = new System.Drawing.Point(3, 22);
            this.btnDecPlntrTarRate.Name = "btnDecPlntrTarRate";
            this.tableLayoutPanel7.SetRowSpan(this.btnDecPlntrTarRate, 2);
            this.btnDecPlntrTarRate.Size = new System.Drawing.Size(94, 49);
            this.btnDecPlntrTarRate.TabIndex = 38;
            this.btnDecPlntrTarRate.UseVisualStyleBackColor = false;
            this.btnDecPlntrTarRate.Click += new System.EventHandler(this.btnDecPlntrTarRate_Click_1);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel6.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.pbRateTarget, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.pbRateRpt, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.labelpbTargetRate, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblRateAct, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(206, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(196, 74);
            this.tableLayoutPanel6.TabIndex = 70;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pbRailPressureTarget, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.pbRailPressureRpt, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblpbPressureTarget, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblPressureAct, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(408, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(196, 74);
            this.tableLayoutPanel5.TabIndex = 70;
            // 
            // lblPressureAct
            // 
            this.lblPressureAct.AutoSize = true;
            this.lblPressureAct.BackColor = System.Drawing.Color.Transparent;
            this.lblPressureAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPressureAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressureAct.ForeColor = System.Drawing.Color.White;
            this.lblPressureAct.Location = new System.Drawing.Point(3, 50);
            this.lblPressureAct.Name = "lblPressureAct";
            this.lblPressureAct.Size = new System.Drawing.Size(59, 24);
            this.lblPressureAct.TabIndex = 64;
            this.lblPressureAct.Text = "0.00";
            this.lblPressureAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cyberProgressBar3, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.cyberProgressBar4, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblRegPosAct, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblpbRegulatorTarget, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(610, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(197, 74);
            this.tableLayoutPanel4.TabIndex = 70;
            // 
            // lblRegPosAct
            // 
            this.lblRegPosAct.AutoSize = true;
            this.lblRegPosAct.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPosAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegPosAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPosAct.ForeColor = System.Drawing.Color.White;
            this.lblRegPosAct.Location = new System.Drawing.Point(3, 50);
            this.lblRegPosAct.Name = "lblRegPosAct";
            this.lblRegPosAct.Size = new System.Drawing.Size(59, 24);
            this.lblRegPosAct.TabIndex = 65;
            this.lblRegPosAct.Text = "0.00";
            this.lblRegPosAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.15743F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.84257F));
            this.tableLayoutPanel2.Controls.Add(this.cyberProgressBar2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRPMtar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRPMact, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cyberProgressBar1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1016, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.27273F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblRPMact
            // 
            this.lblRPMact.AutoSize = true;
            this.lblRPMact.BackColor = System.Drawing.Color.Transparent;
            this.lblRPMact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRPMact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPMact.ForeColor = System.Drawing.Color.White;
            this.lblRPMact.Location = new System.Drawing.Point(3, 50);
            this.lblRPMact.Name = "lblRPMact";
            this.lblRPMact.Size = new System.Drawing.Size(38, 24);
            this.lblRPMact.TabIndex = 67;
            this.lblRPMact.Text = "0.00";
            this.lblRPMact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.35821F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.64179F));
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pbRailFlowrateTarget, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblFlowAct, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.pbRailFlowrate, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblpbFlowTarget, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(813, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(197, 74);
            this.tableLayoutPanel3.TabIndex = 69;
            // 
            // lblFlowAct
            // 
            this.lblFlowAct.AutoSize = true;
            this.lblFlowAct.BackColor = System.Drawing.Color.Transparent;
            this.lblFlowAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFlowAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowAct.ForeColor = System.Drawing.Color.White;
            this.lblFlowAct.Location = new System.Drawing.Point(3, 48);
            this.lblFlowAct.Name = "lblFlowAct";
            this.lblFlowAct.Size = new System.Drawing.Size(49, 26);
            this.lblFlowAct.TabIndex = 66;
            this.lblFlowAct.Text = "0.00";
            this.lblFlowAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // formPlanterBindingSource
            // 
            this.formPlanterBindingSource.DataSource = typeof(AgOpenGPS.Forms.FormPlanter);
            // 
            // FormPlanter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1421, 660);
            this.Controls.Add(this.panelPlanterProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPlanterHealth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlanter";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FormPlanter_Load);
            this.panel1.ResumeLayout(false);
            this.panelPlanterHealth.ResumeLayout(false);
            this.panelPlanterHealth.PerformLayout();
            this.panelPlanterProduct.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barChartPlanter)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formPlanterBindingSource)).EndInit();
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
        private System.Windows.Forms.Label labelpbTargetRate;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelPlanterHealth;
        private System.Windows.Forms.Label lblRateAct;
        private System.Windows.Forms.Panel panelPlanterProduct;
        private ReaLTaiizor.Controls.Button btnProduct;
        private System.Windows.Forms.Label lblRPMact;
        private System.Windows.Forms.Label lblFlowAct;
        private System.Windows.Forms.Label lblRegPosAct;
        private System.Windows.Forms.Label lblPressureAct;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChartPlanter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.BindingSource formPlanterBindingSource;
        private System.Windows.Forms.Button btnModuleReboot;
    }
}