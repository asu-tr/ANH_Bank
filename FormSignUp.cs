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

        private void buttonSignUp_Click(object sender, System.EventArgs e)
        {
            Context context = new Context();

            User user = new User();
            user.TCKN = textBoxID.Text;

            Random rnd = new Random();
            string pwd = rnd.Next(100000, 999999).ToString();
            user.Password = Security.Encryption.Encrypt(pwd, user.TCKN);
            //msgbx show

            user.FirstName = textBoxFN.Text;
            user.LastName = textBoxFN.Text;

            user.DateofBirth = dtp.Value;
            user.Address = textBoxAddress.Text;
            user.Phone = textBoxPhone.Text;
            user.Email = textBoxEmail.Text;

            int sqId = (int)comboBoxSecQ.SelectedValue;
            user.SecurityQuestion = context.SecurityQuestions.ToList().Where(sq => sq.Id == sqId).First();
            user.SecurityQuestionAnswer = textBoxSecA.Text;
            user.InUse = true;
        }

        private void FormSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            string lang = Thread.CurrentThread.CurrentUICulture.Name;
            FillComboBoxSQ(lang);
        }

        #endregion


        #region Methods

        private void FillComboBoxSQ(string language)
        {
            Context context = new Context();
            List<SecurityQuestion> securityQuestions = context.SecurityQuestions.ToList();

            Dictionary<int, string> sqs = new Dictionary<int, string>();

            foreach (SecurityQuestion sq in securityQuestions)
            {
                sqs.Add(sq.Id, sq.SecurityQuestionTranslations.Where(t => t.Language == language).First().Translation);
            }

            comboBoxSecQ.ValueMember = "Key";
            comboBoxSecQ.DisplayMember = "Value";
            comboBoxSecQ.DataSource = new BindingSource(sqs, null);
        }

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        #endregion

        

        
    }
}