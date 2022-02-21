using System.Threading;
using System.Windows.Forms;

namespace ANH_Bank
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