using ANH_Bank.Models;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            RefreshForm();
        }

        #region Events

        private void FormSignUp_FormClosed(object sender, FormClosedEventArgs e)
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

        #endregion

        private void buttonSignUp_Click(object sender, System.EventArgs e)
        {
            User user = new User();
            user.TCKN = long.Parse(textBoxID.Text);

            Random rnd = new Random();
            user.Password = rnd.Next(100000, 999999).ToString();
            //msgbx show

            user.FirstName = textBoxFN.Text;
            user.LastName = textBoxFN.Text;

            user.DateofBirth = dtp.Value;
            user.Address = textBoxAddress.Text;
            user.Phone = textBoxPhone.Text;
            user.Email = textBoxEmail.Text;
            user.SecurityQuestion = (SecurityQuestion)comboBoxSecQ.SelectedItem;
            user.SecurityQuestionAnswer = textBoxSecA.Text;
            user.InUse = true;

        }
    }
}