using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtlantisDeviceSimulator
{



    class TemperatureDevice : IDevice, IObservable<IDevice>
    {
        List<IObserver<IDevice>> observers;
        Metric metric;
        Device device;

        StringArgReturningVoidDelegate print;

        public TemperatureDevice()
        {
            observers = new List<IObserver<IDevice>>();
            device = new Device("temperatureSensor");
        }

        public void Init()
        {
            
            device.Create();
        }

        public IDisposable Subscribe(IObserver<IDevice> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers,observer) ;
        }

       
        public void Start()
        {
            Init();
            while (true)
            {
                Console.WriteLine("Sent new metric " + JsonConvert.SerializeObject(metric));
                GenerateNewData();
                foreach (IObserver<IDevice> observer in observers)
                {
                    observer.OnNext(this);
                }
                Thread.Sleep(1000);
            }
            
        }

        private void GenerateNewData()
        {
            Random random = new Random();
            metric = new Metric(random.NextDouble() * 100,device.id);
            print("Got new metric: " + JsonConvert.SerializeObject(metric)+Environment.NewLine);
        }

        

        public void SendMessage(string message)
        {
            print("Got new message: " + message + Environment.NewLine);
        }
        

        Metric IDevice.GetMetric()
        {
            return metric;
        }

        public void setPrint(StringArgReturningVoidDelegate del)
        {
            print = del;
        }

    }
}
