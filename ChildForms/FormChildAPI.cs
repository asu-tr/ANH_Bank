using ANH_Bank.Currency;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ANH_Bank.ChildForms
{
    public partial class FormChildAPI : Form
    {
        public FormChildAPI()
        {
            InitializeComponent();

            labelAPI.Font = ANHColorsFonts.Font_header2;
            textBoxAPI.Font = ANHColorsFonts.Font_default;
            buttonSave.Font = ANHColorsFonts.Font_header1;

            BackColor = ANHColorsFonts.Color_MainBG;
            buttonSave.BackColor = ANHColorsFonts.Color_ButtonMainBack;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var converter = new Converter(textBoxAPI.Text);
                // let's check if it works
                double usdtry = converter.Convert(1, CurrencyType.USD, CurrencyType.TRY);

                var apikey = new
                {
                    ID = 1,
                    KeyName = "CURRENCY_CONVERTER_API",
                    KeyValue = textBoxAPI.Text
                };
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(apikey);

                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                File.WriteAllText(path + "\\config.json", json);

                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
                // I should add a "API invalid" message to Messages in DB, and show it here
            }
        }
    }
}