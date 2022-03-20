using ANH_Bank.Models;
using System;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            Context context = new Context();
            Helper.CreateDatabase(context);

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            RefreshForm();
        }

        public FormStart(string lang)
        {
            Context context = new Context();
            Helper.CreateDatabase(context);

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            RefreshForm();
        }


        #region Events

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            switch (GetCurrentLanguage())
            {
                case "tr":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;

                case "en":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr");
                    break;

                default:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
            }

            this.Controls.Clear();
            RefreshForm();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.Show();
            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
            this.Hide();
        }

        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region Methods

        private string GetCurrentLanguage()
        {
            CultureInfo currUI = Thread.CurrentThread.CurrentUICulture;
            return currUI.Name;
        }

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }


        #endregion
    }
}