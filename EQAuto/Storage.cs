using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQAuto
{


    class Storage
    {

        struct Constants
        {
            public const string CONFIGURATION_FILE = "configuration.json";
        }

        private static string dataPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DarknessDescending\\EQAuto");
        private static string configurationData = System.IO.Path.Combine(dataPath, Constants.CONFIGURATION_FILE);

        public static bool Exists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }

        public static string Read(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return null;
        }

        public static bool Write(string path, string data)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Directory.CreateDirectory(folderPath);
                }
                File.WriteAllText(path, data);
            }
            catch (Exception e)
            {
                App.Log($"Storage.Write({path}, {data}) error: {e.Message}");
            }
            return true;
        }
    }
}
