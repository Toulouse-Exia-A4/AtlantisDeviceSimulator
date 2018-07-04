using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtlantisDeviceSimulator
{

    
    public class DeviceManager : IObserver<IDevice>
    {
        private StringArgReturningVoidDelegate print;
        private IDisposable unsubscriber;
        Dictionary<string, IDevice> devices;

        internal StringArgReturningVoidDelegate Print { get => print; set => print = value; }

        public DeviceManager()
        {
            devices = new Dictionary<string, IDevice>();
        }
        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {

        }

        public void ForwardMessage(string id,string message)
        {
            devices[id].SendMessage(message);
        }

        public void OnNext(IDevice device)
        {
            Print("Sending new metric " + JsonConvert.SerializeObject(device.GetMetric())+Environment.NewLine);
            MetricSender metric=new MetricSender(device.GetMetric());
            if (!devices.ContainsKey(device.GetMetric().id))
                devices.Add(device.GetMetric().id, device);
            Thread thread = new Thread( metric.Send);
            thread.Start();
        }

        public void SetPrint(StringArgReturningVoidDelegate del)
        {
            Print = del;
        }

    }
}
