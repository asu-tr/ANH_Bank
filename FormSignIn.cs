using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormSignIn : Form
    {
        public FormSignIn(string lan)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lan);
            RefreshForm();
        }

        #region Events

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

        #endregion
    }
}
