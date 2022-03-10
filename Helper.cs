using ANH_Bank.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace ANH_Bank
{
    public class Helper
    {
        #region Database - Default Values

        #region Get Values

        public static string GetDefaultsJson(string objType)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!Directory.Exists(Path.Combine(path, "ANH Bank")))
            {
                CreateANHDirectory();
                path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                path = Path.Combine(path, "ANH Bank");
                path = Path.Combine(path, "Defaults");
                CreateJSONs(path);
            }

            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "ANH Bank");
            path = Path.Combine(path, "Defaults");

            path = string.Concat(path, "\\", objType, ".json");
            return path;
        }

        public static List<Models.Currency> GetCurrencies()
        {
            string json = File.ReadAllText(GetDefaultsJson("Currencies"));
            List<Models.Currency> list = JsonConvert.DeserializeObject<List<Models.Currency>>(json);

            return list;
        }

        #endregion

        #region Set Values

        #region Lists

        public static List<Models.Currency> defCurrencies = new List<Models.Currency>()
        {
            new Models.Currency(){Id = 1, Name = "TRY"},
            new Models.Currency(){Id = 2, Name = "USD"},
            new Models.Currency(){Id = 3, Name = "EUR"},
            new Models.Currency(){Id = 4, Name = "GBP"},
        };

        // OTHER LISTS

        #endregion

        #region Create Directories

        private static void CreateANHDirectory()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Directory.CreateDirectory(Path.Combine(path, "ANH Bank"));

            path = Path.Combine(path, "ANH Bank");
            Directory.CreateDirectory(Path.Combine(path, "Defaults"));
        }

        #endregion

        #region Create JSON

        public static void CreateJSONs(string path)
        {
            CreateJSONCurrencies(path);
            // other classess
        }

        public static void CreateJSONCurrencies(string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(defCurrencies);
            File.WriteAllText(path + "\\Currencies.json", json);
        }

        // CREATE OTHERS defcurr

        #endregion

        #endregion

        public static void AddCurrencies(Context ctx)
        {
            List<Models.Currency> list = GetCurrencies();

            foreach (Models.Currency cur in list)
            {
                ctx.Currencies.Add(cur);
            }
        }

        // add others to ctx

        #endregion


        #region Database - Connection

        public static void CreateDatabase(Context context)
        {
            if (context.Database.Exists())
                return;

            context.Database.Create();

            AddCurrencies(context);

            context.PaymentTypes.Add(new Models.PaymentType { Description = "Card Purchases" });
            context.PaymentTypes.Add(new Models.PaymentType { Description = "Taxes" });
            context.PaymentTypes.Add(new Models.PaymentType { Description = "Bills" });

            SecurityQuestion sq = new SecurityQuestion { Question = "fav_color" };
            context.SecurityQuestions.Add(sq);
            SecurityQuestionTranslation sqt = new SecurityQuestionTranslation { Language = "en", SecurityQuestion = sq, IsDefault = true, Translation = "What is your favourite color?" };
            context.SecurityQuestionTranslations.Add(sqt);
            sqt = new SecurityQuestionTranslation { Language = "tr", SecurityQuestion = sq, IsDefault = false, Translation = "En sevdiğiniz renk?" };
            context.SecurityQuestionTranslations.Add(sqt);

            sq = new SecurityQuestion { Question = "pet_name" };
            context.SecurityQuestions.Add(sq);
            sqt = new SecurityQuestionTranslation { Language = "en", SecurityQuestion = sq, IsDefault = true, Translation = "What is your pet's name?" };
            context.SecurityQuestionTranslations.Add(sqt);
            sqt = new SecurityQuestionTranslation { Language = "tr", SecurityQuestion = sq, IsDefault = false, Translation = "Evcil hayvanınızın adı?" };
            context.SecurityQuestionTranslations.Add(sqt);

            sq = new SecurityQuestion { Question = "bff_name" };
            context.SecurityQuestions.Add(sq);
            sqt = new SecurityQuestionTranslation { Language = "en", SecurityQuestion = sq, IsDefault = true, Translation = "What is your BFF's name?" };
            context.SecurityQuestionTranslations.Add(sqt);
            sqt = new SecurityQuestionTranslation { Language = "tr", SecurityQuestion = sq, IsDefault = false, Translation = "En sevdiğiniz arkadaşınızın adı?" };
            context.SecurityQuestionTranslations.Add(sqt);

            // ADD MESSAGE / TRANSLATIONS

            //user_create_success
            //user_create_success_title
            // first_password

            context.SaveChanges();
        }

        Configuration config;

        public Helper()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        SqlConnection conn;
        public Helper(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }

        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }

        #endregion

        #region Banking Stuff

        public static Account CreateAccount(User user, int currencyId)
        {
            Context context = new Context();

            Account acc = new Account();

            acc.Currency = context.Currencies.Where(c => c.Id == currencyId).First();
            acc.Balance = 0;
            acc.Overdraft = 0;
            acc.InUse = true;
            acc.User = user;

            context.Accounts.Add(acc);

            return acc;
        }

        public static Account CreateAccount(User user, int currencyId, string accountName)
        {
            Context context = new Context();

            Account acc = new Account();

            acc.Name = accountName;
            acc.Currency = context.Currencies.Where(c => c.Id == currencyId).First();
            acc.Balance = 0;
            acc.Overdraft = 0;
            acc.InUse = true;
            acc.User = user;

            context.Accounts.Add(acc);

            return (acc);
        }

        #endregion

        #region Language

        public static string GetMessage(string messageName, string lang)
        {
            Context context = new Context();

            Message msg = context.Messages.Where(m => m.Name == messageName).First();
            string translated = context.MessageTranslations.Where(t => t.Message == msg && t.Language == lang).First().Translation;

            if (translated == null)
            {
                translated = context.MessageTranslations.Where(t => t.Message == msg && t.IsDefault == true).First().Translation;
            }

            return translated;
        }

        #endregion
    }
}