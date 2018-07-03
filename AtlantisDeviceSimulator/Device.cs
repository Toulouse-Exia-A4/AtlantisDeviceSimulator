using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AtlantisDeviceSimulator
{
    class Device
    {
        private string id;
        private string type;

        public Device( string type)
        {
            Type = type;
        }

        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }

        public void Create()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseDeviceEndpoint"] );
            var data = JsonConvert.SerializeObject(this);
            var result= client.PostAsync("/device", new StringContent(data, Encoding.UTF8, "application/json")).Result;
            Device device=JsonConvert.DeserializeObject<Device>(result.Content.ToString());
            Id = device.Id;
        }
    }
}
