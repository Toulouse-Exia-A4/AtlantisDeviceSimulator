using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlantisDeviceSimulator
{
    static class Program
    {

        delegate void StringArgReturningVoidDelegate(string text);
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Form1 form = new Form1();
            

            DeviceManager deviceManager = new DeviceManager();
            deviceManager.setPrint(form.AddLineGateway);
            TemperatureDevice device = new TemperatureDevice();
            device.Subscribe(deviceManager);
            device.setPrint(form.AddLineTemperature);
            Thread thread = new Thread(device.Start);
            thread.Start();

            
            Application.EnableVisualStyles();
            Application.Run(form);
            
        }
    }
}
