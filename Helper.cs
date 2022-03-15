using ANH_Bank.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ANH_Bank
{
    public class Helper
    {
        #region Database - Default Values

        #region Get Values

        private static string GetDefaultsJson(string objType)
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

        private static List<Models.Currency> GetCurrencies()
        {
            string json = File.ReadAllText(GetDefaultsJson("Currencies"));
            List<Models.Currency> list = JsonConvert.DeserializeObject<List<Models.Currency>>(json);

            return list;
        }
        private static List<PaymentType> GetPaymentTypes()
        {
            string json = File.ReadAllText(GetDefaultsJson("PaymentTypes"));
            List<PaymentType> list = JsonConvert.DeserializeObject<List<PaymentType>>(json);

            return list;
        }
        private static List<SecurityQuestion> GetSecurityQuestions()
        {
            string json = File.ReadAllText(GetDefaultsJson("SecurityQuestions"));
            List<SecurityQuestion> list = JsonConvert.DeserializeObject<List<SecurityQuestion>>(json);

            return list;
        }
        private static List<SecurityQuestionTranslation> GetSecurityQuestionTranslations()
        {
            string json = File.ReadAllText(GetDefaultsJson("SecurityQuestionTranslations"));
            List<SecurityQuestionTranslation> list = JsonConvert.DeserializeObject<List<SecurityQuestionTranslation>>(json);

            return list;
        }
        private static List<Message> GetMessages()
        {
            string json = File.ReadAllText(GetDefaultsJson("Messages"));
            List<Message> list = JsonConvert.DeserializeObject<List<Message>>(json);

            return list;
        }
        private static List<MessageTranslation> GetMessageTranslations()
        {
            string json = File.ReadAllText(GetDefaultsJson("MessageTranslations"));
            List<MessageTranslation> list = JsonConvert.DeserializeObject<List<MessageTranslation>>(json);

            return list;
        }

        #endregion

        #region Set Values

        #region Lists

        private static List<Models.Currency> defCurrencies = new List<Models.Currency>()
        {
            new Models.Currency(){Id = 1, Name = "TRY"},
            new Models.Currency(){Id = 2, Name = "USD"},
            new Models.Currency(){Id = 3, Name = "EUR"},
            new Models.Currency(){Id = 4, Name = "GBP"}
        };

        private static List<PaymentType> defPaymentTypes = new List<PaymentType>()
        {
            new PaymentType(){Id = 1, Description = "Card Purchases"},
            new PaymentType(){Id = 1, Description = "Taxes"},
            new PaymentType(){Id = 1, Description = "Bills"}
        };

        private static List<SecurityQuestion> defSecurityQuestions = new List<SecurityQuestion>()
        {
            new SecurityQuestion {Id = 1, Question = "fav_color"},
            new SecurityQuestion {Id = 2, Question = "pet_name"},
            new SecurityQuestion {Id = 3, Question = "bff_name"}
        };

        private static List<SecurityQuestionTranslation> defSQTs = new List<SecurityQuestionTranslation>()
        {
            new SecurityQuestionTranslation { Language = "en", SecurityQuestion = new SecurityQuestion { Id = 1, Question = "fav_color"}, IsDefault = true, Translation = "What is your favourite color?" },
            new SecurityQuestionTranslation { Language = "tr", SecurityQuestion = new SecurityQuestion { Id = 1, Question = "fav_color"}, IsDefault = false, Translation = "En sevdiğiniz renk?" },

            new SecurityQuestionTranslation { Language = "en", SecurityQuestion = new SecurityQuestion { Id = 2, Question = "pet_name"}, IsDefault = true, Translation = "What is your pet's name?" },
            new SecurityQuestionTranslation { Language = "tr", SecurityQuestion = new SecurityQuestion { Id = 2, Question = "pet_name"}, IsDefault = false, Translation = "Evcil hayvanınızın adı?" },

            new SecurityQuestionTranslation { Language = "en", SecurityQuestion = new SecurityQuestion { Id = 3, Question = "bff_name"}, IsDefault = true, Translation = "What is your BFF's name?" },
            new SecurityQuestionTranslation { Language = "tr", SecurityQuestion = new SecurityQuestion { Id = 3, Question = "bff_name"}, IsDefault = false, Translation = "En sevdiğiniz arkadaşınızın adı?" }
        };

        private static List<Message> defMessages = new List<Message>()
        {
            new Message { Id = 1, Name = "user_create_success"},
            new Message { Id = 2, Name = "user_create_success_title"},
            new Message { Id = 3, Name = "first_password"},
            new Message { Id = 4, Name = "login_error"},
            new Message { Id = 5, Name = "login_error_title"},
            new Message { Id = 6, Name = "account"},
            new Message { Id = 7, Name = "new_balance"},
            new Message { Id = 7, Name = "deposit_success_title"}
        };

        private static List<MessageTranslation> defMessageTranslations = new List<MessageTranslation>()
        {
            new MessageTranslation { Language = "en", Message = new Message{Id = 1, Name = "user_create_success"}, IsDefault = true, Translation = "User created successfully!"},
            new MessageTranslation { Language = "tr", Message = new Message{Id = 1, Name = "user_create_success"}, IsDefault = false, Translation = "Kullanıcı başarıyla oluşturuldu!"},

            new MessageTranslation { Language = "en", Message = new Message{Id = 2, Name = "user_create_success_title"}, IsDefault = true, Translation = "SUCCESS!"},
            new MessageTranslation { Language = "tr", Message = new Message{Id = 2, Name = "user_create_success_title"}, IsDefault = false, Translation = "BAŞARI!"},

            new MessageTranslation { Language = "en", Message = new Message{Id = 3, Name = "first_password"}, IsDefault = true, Translation = "Your password is: "},
            new MessageTranslation { Language = "tr", Message = new Message{Id = 3, Name = "first_password"}, IsDefault = false, Translation = "Şifreniz: "},

            new MessageTranslation { Language = "en", Message = new Message{Id = 4, Name = "login_error"}, IsDefault = true, Translation = "Invalid TCKN or password."},
            new MessageTranslation { Language = "tr", Message = new Message{Id = 4, Name = "login_error"}, IsDefault = false, Translation = "Geçersiz TCKN veya şifre."},

            new MessageTranslation { Language = "en", Message = new Message{Id = 5, Name = "login_error_title"}, IsDefault = true, Translation = "Log In Error"},
            new MessageTranslation { Language = "tr", Message = new Message{Id = 5, Name = "login_error_title"}, IsDefault = false, Translation = "Oturum Açma Hatası"},

            new MessageTranslation { Language = "en", Message = new Message{Id = 6, Name = "account"}, IsDefault = true, Translation = "Account "},
            new MessageTranslation { Language = "tr", Message = new Message{Id = 6, Name = "account"}, IsDefault = false, Translation = "Hesap "},

            new MessageTranslation { Language = "en", Message = new Message{Id = 7, Name = "new_balance"}, IsDefault = true, Translation = "Your new balance is: "},
            new MessageTranslation { Language = "tr", Message = new Message{Id = 7, Name = "new_balance"}, IsDefault = false, Translation = "Yeni hesap bakiyeniz: "},

            new MessageTranslation { Language = "en", Message = new Message{Id = 8, Name = "deposit_success_title"}, IsDefault = true, Translation = "Deposited Successfully!"},
            new MessageTranslation { Language = "tr", Message = new Message{Id = 8, Name = "deposit_success_title"}, IsDefault = false, Translation = "Para Yatırma Başarılı!"}
        };

        #endregion

        #region Create Directory

        private static void CreateANHDirectory()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Directory.CreateDirectory(Path.Combine(path, "ANH Bank"));

            path = Path.Combine(path, "ANH Bank");
            Directory.CreateDirectory(Path.Combine(path, "Defaults"));
        }

        #endregion

        #region Create JSON

        private static void CreateJSONs(string path)
        {
            CreateJSONCurrencies(path);
            CreateJSONPaymentTypes(path);
            CreateJSONSecurityQuestions(path);
            CreateJSONSecurityQuestionTranslations(path);
            CreateJSONMessages(path);
            CreateJSONMessageTranslations(path);
        }

        private static void CreateJSONCurrencies(string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(defCurrencies);
            File.WriteAllText(path + "\\Currencies.json", json);
        }

        private static void CreateJSONPaymentTypes(string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(defPaymentTypes);
            File.WriteAllText(path + "\\PaymentTypes.json", json);
        }

        private static void CreateJSONSecurityQuestions(string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(defSecurityQuestions);
            File.WriteAllText(path + "\\SecurityQuestions.json", json);
        }

        private static void CreateJSONSecurityQuestionTranslations(string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(defSQTs);
            File.WriteAllText(path + "\\SecurityQuestionTranslations.json", json);
        }

        private static void CreateJSONMessages(string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(defMessages);
            File.WriteAllText(path + "\\Messages.json", json);
        }

        private static void CreateJSONMessageTranslations(string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(defMessageTranslations);
            File.WriteAllText(path + "\\MessageTranslations.json", json);
        }

        #endregion

        #endregion

        #region Fill Tables (Methods)

        private static void FillAllTables(Context ctx)
        {
            AddCurrencies(ctx);
            AddPaymentTypes(ctx);
            AddSecurityQuestionsAndTranslations(ctx);
            AddMessagesAndTranslations(ctx);
        }

        private static void AddCurrencies(Context ctx)
        {
            List<Models.Currency> list = GetCurrencies();
            foreach (Models.Currency cur in list)
            {
                ctx.Currencies.Add(cur);
            }
        }
        private static void AddPaymentTypes(Context ctx)
        {
            List<PaymentType> list = GetPaymentTypes();
            foreach (PaymentType pt in list)
            {
                ctx.PaymentTypes.Add(pt);
            }
        }
        private static void AddSecurityQuestionsAndTranslations(Context ctx)
        {
            List<SecurityQuestionTranslation> listsqt = GetSecurityQuestionTranslations();
            List<SecurityQuestion> listsq = GetSecurityQuestions();

            foreach (SecurityQuestion sq in listsq)
            {
                ctx.SecurityQuestions.Add(sq);
                foreach (SecurityQuestionTranslation sqt in listsqt)
                {
                    if (sqt.SecurityQuestion.Id == sq.Id)
                    {
                        sqt.SecurityQuestion = sq;
                        ctx.SecurityQuestionTranslations.Add(sqt);
                    }
                }
            }
        }
        private static void AddMessagesAndTranslations(Context ctx)
        {
            List<Message> listmsg = GetMessages();
            List<MessageTranslation> listmsgt = GetMessageTranslations();

            foreach (Message m in listmsg)
            {
                ctx.Messages.Add(m);
                foreach (MessageTranslation mt in listmsgt)
                {
                    if (mt.Message.Id == m.Id)
                    {
                        mt.Message = m;
                        ctx.MessageTranslations.Add(mt);
                    }
                }
            }
        }

        #endregion

        #endregion

        #region Database - Connection

        public static void CreateDatabase(Context context)
        {
            if (context.Database.Exists())
                return;

            context.Database.Create();

            FillAllTables(context);

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

        public static Account CreateAccount(User user, Models.Currency cur)
        {
            Context context = new Context();

            Account acc = new Account();

            acc.Currency = cur;
            acc.Balance = 0;
            acc.Overdraft = 0;
            acc.InUse = true;
            acc.User = user;

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

        public static string GetCurrencyAPIKey()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string js = File.ReadAllText(path + "\\config.json");

            List<Key> keys = JsonConvert.DeserializeObject<List<Key>>(js);
            string key = keys[0].KeyValue;

            return key;
        }

        #endregion

        #region Language

        public static string GetMessage(string messageName, string lang)
        {
            Context context = new Context();

            Message msg = context.Messages.Where(m => m.Name == messageName).First();
            string translated = context.MessageTranslations.ToList().Where(t => t.Message == msg && t.Language == lang).First().Translation;

            if (translated == null)
            {
                translated = context.MessageTranslations.Where(t => t.Message == msg && t.IsDefault == true).First().Translation;
            }

            return translated;
        }

        #endregion
    }
}