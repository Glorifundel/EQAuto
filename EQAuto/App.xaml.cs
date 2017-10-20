using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace EQAuto
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string Name { get { return Assembly.GetExecutingAssembly().GetName().Name; } }
        public static Configuration configuration = new Configuration();

        App ()
        {

            if(!App.configuration.Read())
            {
                App.configuration.logPath = "C:/Program Files/EverQuest/Logs";
                App.configuration.filePath = "C:/Program Files/EverQuest/Logs/eqlog_Glorifundel_P1999PVP.txt";

                App.configuration.Write();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        /// <param name="prefix"></param>
        /// <param name="suffix"></param>
        public static void Log(string log, string prefix = "====", string suffix = "====")
        {
            System.Diagnostics.Debug.WriteLine(prefix + log + suffix);
        }
    }
}
