using System;
using System.Data;
using System.Data.Sql;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ANH_Bank
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
            this.labelServer.Font = ANHColorsFonts.Font_default;
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            ServiceController service = new ServiceController("SQLBrowser");
            ServiceCtrl service2 = new ServiceCtrl("SQLBrowser");

            if ((service.Status.Equals(ServiceControllerStatus.Stopped)) || (service.Status.Equals(ServiceControllerStatus.StopPending)))
            {
                service2.StartupType = ServiceStartMode.Automatic.ToString();
                service.Start();
                Application.Restart();
                Environment.Exit(0);
            }
                

            string myServer = Environment.MachineName;

            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString())
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                    {
                        comboBoxServerName.Items.Add(System.IO.Path.Combine(servers.Rows[i]["ServerName"].ToString(), servers.Rows[i]["InstanceName"].ToString()));
                    }
                        
                    else
                        comboBoxServerName.Items.Add(servers.Rows[i]["ServerName"].ToString());
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("data source={0};initial catalog=ANH_DB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework", comboBoxServerName.Text);

            Helper setting = new Helper();
            setting.SaveConnectionString("ANH_DB", connectionString);

            FormStart formStart = new FormStart();
            formStart.Show();
            this.Hide();
        }
    }
}