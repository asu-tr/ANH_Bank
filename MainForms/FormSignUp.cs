﻿using ANH_Bank.Models;
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

            context.Users.Add(user);

            if (context.Users.Contains(user))
            {
                Account a = Helper.CreateAccount(user, 1);
                context.SaveChanges();

                if (context.Accounts.Contains(a))
                {
                    string lang = Thread.CurrentThread.CurrentUICulture.Name;
                    //DialogResult dr = MessageBox.Show(Helper.GetMessage("user_create_success", lang) + Helper.GetMessage("first_password", lang), Helper.GetMessage("user_create_success_title", lang), MessageBoxButtons.OK);
                    DialogResult dr = MessageBox.Show("Account created succesfully. " + "Your password is: " + pwd.ToString(), Helper.GetMessage("user_create_success_title", lang), MessageBoxButtons.OK);

                    if (dr == DialogResult.OK)
                    {
                        FormSignIn formSignIn = new FormSignIn();
                        formSignIn.Show();
                        this.Hide();
                    }
                }
            }
            
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