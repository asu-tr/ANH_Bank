namespace ANH_Bank.ChildForms
{
    partial class FormChildAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChildAPI));
            this.labelAPI = new System.Windows.Forms.Label();
            this.textBoxAPI = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAPI
            // 
            resources.ApplyResources(this.labelAPI, "labelAPI");
            this.labelAPI.Name = "labelAPI";
            // 
            // textBoxAPI
            // 
            resources.ApplyResources(this.textBoxAPI, "textBoxAPI");
            this.textBoxAPI.Name = "textBoxAPI";
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormChildAPI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAPI);
            this.Controls.Add(this.labelAPI);
            this.Name = "FormChildAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAPI;
        private System.Windows.Forms.TextBox textBoxAPI;
        private System.Windows.Forms.Button buttonSave;
    }
}