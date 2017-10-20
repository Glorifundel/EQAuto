using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EQAuto
{
    public class Configuration
    {
        public string logPath = null;
        public string filePath = null;

        public bool Read()
        {
            string json = Storage.Read(Storage.configurationFile);
            if (json != null)
            {
                Configuration fileconfig = JsonConvert.DeserializeObject<Configuration>(json);
                this.logPath = fileconfig.logPath;
                this.filePath = fileconfig.filePath;
                return true;
            }

            return false;

        }

        public bool Write()
        {
            return Storage.Write(Storage.configurationFile, JsonConvert.SerializeObject(this));
        }

    }
}
