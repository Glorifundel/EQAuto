using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EQAuto
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

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
