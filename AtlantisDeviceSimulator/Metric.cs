using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantisDeviceSimulator
{
    class Metric
    {
        DateTime date;
        string id;
        private double value;

        public Metric(double value,string deviceId)
        {
            Value = value;
            Date = DateTime.Now;
            Id = deviceId;
        }
        

        public string Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Value { get => value; set => this.value = value; }
    }
}
