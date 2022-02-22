using ANH_Bank.Currency;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using ANH_Bank.Models;
using System.Collections.Generic;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildRates : Form
    {
        public FormChildRates()
        {
            RefreshForm();
        }

        #region Events

        private void FormChildRates_Load(object sender, System.EventArgs e)
        {
            var converter = new Converter(GetCurrencyAPIKey());

            double usdtry = converter.Convert(1, CurrencyType.USD, CurrencyType.TRY);
            labelUSDVal.Text = usdtry.ToString();

            double eurtry = converter.Convert(1, CurrencyType.EUR, CurrencyType.TRY);
            labelEURVal.Text = eurtry.ToString();

            double gbptry = converter.Convert(1, CurrencyType.GBP, CurrencyType.TRY);
            labelGBPVal.Text = gbptry.ToString();
        }

        #endregion

        #region Methods

        private string GetCurrencyAPIKey()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string js = File.ReadAllText(path + "\\config.json");

            List<Key> keys = JsonConvert.DeserializeObject<List<Key>>(js);
            string key = keys[0].KeyValue;
            
            return key;
        }

        private void RefreshForm()
        {
            InitializeComponent();
            MyInitializeComponent();
        }

        #endregion
    }
}