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
            if (lan == "tr")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr");
            }
            else 
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
            InitializeComponent();
        }

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        private void FormSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
