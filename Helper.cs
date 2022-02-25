using ANH_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANH_Bank
{
    public class Helper
    {
        public static void CreateDatabase(Context context)
        {
            if (context.Database.Exists())
                return;

            context.Database.Create();
        }
    }
}
