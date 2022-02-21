using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildTax : Form
    {
        public FormChildTax()
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