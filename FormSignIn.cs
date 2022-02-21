using System;
using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            RefreshForm();
        }

        #region Events

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            int UserID = 0; // will be deleted
            // sign in check and return id

            OpenMainScreen(UserID);
        }

        private void FormSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        private void OpenMainScreen(int id)
        {
            FormMain fm = new FormMain(Thread.CurrentThread.CurrentUICulture.Name, id);
            fm.Show();
            this.Hide();
        }

        #endregion

    }
}