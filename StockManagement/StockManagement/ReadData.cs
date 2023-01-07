using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace StockManagement
{
    public class ReadData
    {

        public StockModel Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {

                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockModel>(json);

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}
