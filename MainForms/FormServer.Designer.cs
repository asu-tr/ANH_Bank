namespace ANH_Bank
{
    partial class FormServer
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
            this.labelServer.Font =ANHColorsFonts.Font_header2;
            this.comboBoxServerName.Font = ANHColorsFonts.Font_default;
            this.buttonConnect.Font = ANHColorsFonts.Font_header3;

            this.BackColor = ANHColorsFonts.Color_MainBG;
            this.buttonConnect.BackColor = ANHColorsFonts.Color_ButtonMainBack;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.comboBoxServerName = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxServerName
            // 
            resources.ApplyResources(this.comboBoxServerName, "comboBoxServerName");
            this.comboBoxServerName.FormattingEnabled = true;
            this.comboBoxServerName.Name = "comboBoxServerName";
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelServer
            // 
            resources.ApplyResources(this.labelServer, "labelServer");
            this.labelServer.Name = "labelServer";
            // 
            // FormServer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormServer";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxServerName;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelServer;
    }
}