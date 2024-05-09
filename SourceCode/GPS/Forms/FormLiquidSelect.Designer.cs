namespace AgOpenGPS.Forms
{
    partial class FormLiquidSelect
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
            this.btnPlanter = new ReaLTaiizor.Controls.Button();
            this.btnSprayer = new ReaLTaiizor.Controls.Button();
            this.SuspendLayout();
            // 
            // btnPlanter
            // 
            this.btnPlanter.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnPlanter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanter.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnPlanter.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnPlanter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlanter.Image = null;
            this.btnPlanter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanter.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnPlanter.Location = new System.Drawing.Point(64, 72);
            this.btnPlanter.Name = "btnPlanter";
            this.btnPlanter.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnPlanter.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnPlanter.Size = new System.Drawing.Size(107, 67);
            this.btnPlanter.TabIndex = 0;
            this.btnPlanter.Text = "PLANTER";
            this.btnPlanter.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPlanter.Click += new System.EventHandler(this.btnPlanter_Click);
            // 
            // btnSprayer
            // 
            this.btnSprayer.BackColor = System.Drawing.Color.Transparent;
            this.btnSprayer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSprayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSprayer.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnSprayer.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSprayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSprayer.Image = null;
            this.btnSprayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSprayer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSprayer.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSprayer.Location = new System.Drawing.Point(223, 72);
            this.btnSprayer.Name = "btnSprayer";
            this.btnSprayer.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnSprayer.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnSprayer.Size = new System.Drawing.Size(107, 67);
            this.btnSprayer.TabIndex = 1;
            this.btnSprayer.Text = "SPRAYER";
            this.btnSprayer.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSprayer.Click += new System.EventHandler(this.btnSprayer_Click);
            // 
            // FormLiquidSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 251);
            this.Controls.Add(this.btnSprayer);
            this.Controls.Add(this.btnPlanter);
            this.Name = "FormLiquidSelect";
            this.Text = "FormLiquidSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Button btnPlanter;
        private ReaLTaiizor.Controls.Button btnSprayer;
    }
}