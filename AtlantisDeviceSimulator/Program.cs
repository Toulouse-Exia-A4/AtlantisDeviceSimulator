using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlantisDeviceSimulator
{
    public delegate void StringArgReturningVoidDelegate(string text);
    static class Program
    {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Form1 form = new Form1();
            

            DeviceManager deviceManager = new DeviceManager();
            deviceManager.SetPrint(form.AddLineGateway);
            TemperatureDevice device = new TemperatureDevice();
            device.Subscribe(deviceManager);
            device.setPrint(form.AddLineTemperature);
            Thread thread = new Thread(device.Start);
            thread.Start();


            ServiceHost serviceHost = new ServiceHost(  new MessageListener(deviceManager));
            ((ServiceBehaviorAttribute)serviceHost.Description.Behaviors[typeof(ServiceBehaviorAttribute)]).InstanceContextMode= InstanceContextMode.Single;
            serviceHost.Open();

            Application.EnableVisualStyles();
            Application.Run(form);
            
        }
    }
}
