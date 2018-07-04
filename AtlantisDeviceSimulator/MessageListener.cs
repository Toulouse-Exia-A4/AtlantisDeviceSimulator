using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;

namespace AtlantisDeviceSimulator
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "MessageListener" à la fois dans le code et le fichier de configuration.
    public class MessageListener : IMessageListener
    {

        private DeviceManager deviceManager;

        public MessageListener(DeviceManager deviceManager)
        {
            this.deviceManager = deviceManager;
        }

        public void GetMessage(string message)
        {
            dynamic msg = JsonConvert.DeserializeObject(message);
            deviceManager.ForwardMessage(msg["id"], msg["message"]);
        }
    }
}
