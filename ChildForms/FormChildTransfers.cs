using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank
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