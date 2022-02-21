using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormChildCreditCard : Form
    {
        public FormChildCreditCard()
        {
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