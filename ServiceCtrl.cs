using System;
using System.ComponentModel;
using System.Management;
using System.ServiceProcess;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.ServiceProcess.Design;
using System.Text;
using System.Threading;

namespace ANH_Bank
{
    public class ServiceCtrl: ServiceController
    {
        public ServiceCtrl() : base()
        { }
        public ServiceCtrl(string name) : base(name)
        { }
        public ServiceCtrl(string name, string machineName) : base(name, machineName)
        { }

        public string StartupType
        {
            get
            {
                if (this.ServiceName != null)
                {
                    //construct the management path
                    string path = "Win32_Service.Name='" + this.ServiceName + "'";
                    ManagementPath p = new ManagementPath(path);
                    //construct the management object
                    ManagementObject ManagementObj = new ManagementObject(p);
                    return ManagementObj["StartMode"].ToString();
                }
                else
                {
                    return null;
                }
            }
                set
                {
                    if (value != "Automatic" && value != "Manual" && value != "Disabled" && value != "Boot" && value != "System")
                        throw new Exception("The valid values are Automatic, Manual, Boot, System or Disabled");

                    if (this.ServiceName != null)
                    {
                        //construct the management path
                        string path = "Win32_Service.Name='" + this.ServiceName + "'";
                        ManagementPath p = new ManagementPath(path);
                        //construct the management object
                        ManagementObject ManagementObj = new ManagementObject(p);
                        //we will use the invokeMethod method of the ManagementObject class
                        object[] parameters = new object[1];
                        parameters[0] = value;
                        ManagementObj.InvokeMethod("ChangeStartMode", parameters);
                    }
                }
            }
        }
}
