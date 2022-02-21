using System.Windows.Forms;

namespace ANH_Bank.ChildForms
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