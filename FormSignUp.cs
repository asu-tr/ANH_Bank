using ANH_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            user.TCKN = textBoxID.Text;

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

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            Context context = new Context();

            List<SecurityQuestion> list = context.SecurityQuestions.ToList();
            string lang = Thread.CurrentThread.CurrentUICulture.Name;

            foreach (SecurityQuestion sq in list)
            {
                comboBoxSecQ.Items.Add(sq);

                //SecurityQuestionTranslation defsqt = sq.SecurityQuestionTranslations.Where(t=> t.IsDefault == true).First();
                //comboBoxSecQ.DisplayMember = sq.SecurityQuestionTranslations.Where(t => t.Language == lang).DefaultIfEmpty(defsqt).First().Translation.ToString();
                comboBoxSecQ.DisplayMember = sq.SecurityQuestionTranslations.Where(t => t.Language == lang).First().Translation;
            }
        }
    }
}