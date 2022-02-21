using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormChildBills : Form
    {
        public FormChildBills()
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