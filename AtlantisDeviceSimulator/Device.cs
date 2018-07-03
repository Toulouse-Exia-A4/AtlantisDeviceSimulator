using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AtlantisDeviceSimulator
{
    class Device
    {
        private string _id;
        private string type;

        public Device( string type)
        {
            deviceType = type;
        }

        public string id { get => _id; set => _id = value; }
        public string deviceType { get => type; set => type = value; }

        public void Create()
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseDeviceEndpoint"] );
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            var data = JsonConvert.SerializeObject(this);
            var result= httpClient.PostAsync("/DeviceService/device", new StringContent(JsonConvert.SerializeObject(new { deviceType = deviceType}), Encoding.UTF8, "application/json")).Result;
            dynamic jsonObject = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result);
            JObject hey = jsonObject["RegisterDeviceResult"];
            Device device=JsonConvert.DeserializeObject<Device>(hey.ToString());
            id = device.id;
        }
    }
}
