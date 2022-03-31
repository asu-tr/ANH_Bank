using ANH_Bank.ChildForms;
using ANH_Bank.Models;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormSignIn : Form
    {
        string lang = Thread.CurrentThread.CurrentUICulture.Name;

        public FormSignIn()
        {
            RefreshForm();
        }

        #region Events

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormStart form = new FormStart(lang);
            form.Show();
            this.Hide();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Context ctx = new Context();
            User user = ctx.Users.ToList().Where(u => u.TCKN == textBoxID.Text && Security.Decryption.Decrypt(u.Password, u.TCKN) == textBoxPwd.Text).FirstOrDefault();

            if (user != null)
            {
                int UserID = user.Id;

                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                path = Path.Combine(path, "config.json");
                bool fileExist = File.Exists(path);

                if (!fileExist)
                {
                    FormChildAPI formChildAPI = new FormChildAPI();
                    formChildAPI.ShowDialog();
                }

                OpenMainScreen(UserID);
            }
            else
            {
                MessageBox.Show(Helper.GetMessage("login_error", lang), Helper.GetMessage("login_error_title", lang), MessageBoxButtons.OK);
            }
        }

        private void FormSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPwd.Focus();
            }
        }

        private void textBoxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSignIn.PerformClick();
            }
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
            FormMain fm = new FormMain(id);
            fm.Show();
            this.Hide();
        }

        #endregion
    }
}