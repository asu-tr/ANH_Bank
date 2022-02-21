namespace ANH_Bank
{
    partial class FormChildMain
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
            this.labelWelcome.Font = ANHColorsFonts.FontANH_header2;
            this.labelLatest.Font = ANHColorsFonts.FontANH_header2;
        }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChildMain));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.flpAccounts = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLatest = new System.Windows.Forms.FlowLayoutPanel();
            this.labelLatest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            resources.ApplyResources(this.labelWelcome, "labelWelcome");
            this.labelWelcome.Name = "labelWelcome";
            // 
            // flpAccounts
            // 
            resources.ApplyResources(this.flpAccounts, "flpAccounts");
            this.flpAccounts.Name = "flpAccounts";
            // 
            // flpLatest
            // 
            resources.ApplyResources(this.flpLatest, "flpLatest");
            this.flpLatest.Name = "flpLatest";
            // 
            // labelLatest
            // 
            resources.ApplyResources(this.labelLatest, "labelLatest");
            this.labelLatest.Name = "labelLatest";
            // 
            // FormChildMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLatest);
            this.Controls.Add(this.flpLatest);
            this.Controls.Add(this.flpAccounts);
            this.Controls.Add(this.labelWelcome);
            this.Name = "FormChildMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.FlowLayoutPanel flpAccounts;
        private System.Windows.Forms.FlowLayoutPanel flpLatest;
        private System.Windows.Forms.Label labelLatest;
    }
}