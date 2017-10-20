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

        public struct Constants
        {
            public const string CONFIGURATION_FILE = "configuration.json";
        }

        /// <summary>
        /// C:\Users\Glorifundel\AppData\Roaming\DarknessDescending\EQAuto\
        /// </summary>
        public readonly static string dataPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DarknessDescending\\EQAuto");
        public readonly static string configurationFile = System.IO.Path.Combine(dataPath, Constants.CONFIGURATION_FILE);

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
            App.Log("Read path: " + path);
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
                    string directory = Path.GetDirectoryName(path);
                    if(!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    File.Create(path);
                }
                File.WriteAllText(path, data);
            }
            catch (Exception e)
            {
                App.Log($"Storage.Write({path}, {data}) error: {e.Message}");
                return false;
            }
            return true;
        }
    }
}
