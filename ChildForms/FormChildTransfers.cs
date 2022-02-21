using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildTransfers : Form
    {
        public FormChildTransfers()
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