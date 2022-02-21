using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormChildBuy : Form
    {
        public FormChildBuy(string lan)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lan);
            RefreshForm();
        }

        #region Methods

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        #endregion
    }
}