using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtlantisDeviceSimulator
{

    
    class DeviceManager : IObserver<IDevice>
    {
        StringArgReturningVoidDelegate print;
        private IDisposable unsubscriber;
        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {

        }

        public void OnNext(IDevice device)
        {
            print("Sending new metric " + JsonConvert.SerializeObject(device.GetMetric())+Environment.NewLine);
            MetricSender metric=new MetricSender(device.GetMetric()); //Thread it
            Thread thread = new Thread( metric.Send);
            thread.Start();
        }

        public void setPrint(StringArgReturningVoidDelegate del)
        {
            print = del;
        }

    }
}
