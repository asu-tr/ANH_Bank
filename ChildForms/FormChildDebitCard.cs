using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormChildDebitCard : Form
    {
        public FormChildDebitCard()
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