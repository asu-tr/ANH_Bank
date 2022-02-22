using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    partial class FormChildRates
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

        private void MyInitializeComponent()
        {
            this.BackColor = ANHColorsFonts.Color_MainBG;

            foreach (Control control in this.Controls)
            {
                Label l = control as Label;
                if (l != null)
                {
                    if (l.Name.Substring(l.Name.Length - 3, 3) == "Val")
                        l.Font = ANHColorsFonts.Font_default;
                    else
                        l.Font = ANHColorsFonts.Font_header3;
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUSD = new System.Windows.Forms.Label();
            this.labelUSDVal = new System.Windows.Forms.Label();
            this.labelEUR = new System.Windows.Forms.Label();
            this.labelEURVal = new System.Windows.Forms.Label();
            this.labelGBP = new System.Windows.Forms.Label();
            this.labelGBPVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUSD
            // 
            this.labelUSD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(172, 89);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(36, 16);
            this.labelUSD.TabIndex = 0;
            this.labelUSD.Text = "USD";
            this.labelUSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUSDVal
            // 
            this.labelUSDVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUSDVal.AutoSize = true;
            this.labelUSDVal.Location = new System.Drawing.Point(159, 144);
            this.labelUSDVal.Name = "labelUSDVal";
            this.labelUSDVal.Size = new System.Drawing.Size(30, 16);
            this.labelUSDVal.TabIndex = 1;
            this.labelUSDVal.Text = "N/A";
            this.labelUSDVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEUR
            // 
            this.labelEUR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEUR.AutoSize = true;
            this.labelEUR.Location = new System.Drawing.Point(172, 247);
            this.labelEUR.Name = "labelEUR";
            this.labelEUR.Size = new System.Drawing.Size(36, 16);
            this.labelEUR.TabIndex = 0;
            this.labelEUR.Text = "EUR";
            this.labelEUR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEURVal
            // 
            this.labelEURVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEURVal.AutoSize = true;
            this.labelEURVal.Location = new System.Drawing.Point(159, 302);
            this.labelEURVal.Name = "labelEURVal";
            this.labelEURVal.Size = new System.Drawing.Size(30, 16);
            this.labelEURVal.TabIndex = 1;
            this.labelEURVal.Text = "N/A";
            this.labelEURVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGBP
            // 
            this.labelGBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGBP.AutoSize = true;
            this.labelGBP.Location = new System.Drawing.Point(172, 405);
            this.labelGBP.Name = "labelGBP";
            this.labelGBP.Size = new System.Drawing.Size(35, 16);
            this.labelGBP.TabIndex = 0;
            this.labelGBP.Text = "GBP";
            this.labelGBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGBPVal
            // 
            this.labelGBPVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGBPVal.AutoSize = true;
            this.labelGBPVal.Location = new System.Drawing.Point(159, 460);
            this.labelGBPVal.Name = "labelGBPVal";
            this.labelGBPVal.Size = new System.Drawing.Size(30, 16);
            this.labelGBPVal.TabIndex = 1;
            this.labelGBPVal.Text = "N/A";
            this.labelGBPVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChildRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 606);
            this.Controls.Add(this.labelGBPVal);
            this.Controls.Add(this.labelEURVal);
            this.Controls.Add(this.labelUSDVal);
            this.Controls.Add(this.labelGBP);
            this.Controls.Add(this.labelEUR);
            this.Controls.Add(this.labelUSD);
            this.Name = "FormChildRates";
            this.Text = "FormChildRates";
            this.Load += new System.EventHandler(this.FormChildRates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.Label labelUSDVal;
        private System.Windows.Forms.Label labelEUR;
        private System.Windows.Forms.Label labelEURVal;
        private System.Windows.Forms.Label labelGBP;
        private System.Windows.Forms.Label labelGBPVal;
    }
}