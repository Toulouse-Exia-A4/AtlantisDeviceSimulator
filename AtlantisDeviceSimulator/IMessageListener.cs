using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

using System.ServiceModel.Web;
using System.Text;

namespace AtlantisDeviceSimulator
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IMessageListener" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IMessageListener
    {
        [OperationContract]
        [WebInvoke(
        Method = "POST",
        UriTemplate = "/message",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json
        )]
        void GetMessage(string message);
    }
}
