using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildRates : Form
    {
        public FormChildRates()
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