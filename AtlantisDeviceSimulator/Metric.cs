using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantisDeviceSimulator
{
    public class Metric
    {
        DateTime _date;
        string _id;
        private double _value;

        public Metric(double value,string deviceId)
        {
            this.value = value;
            date = DateTime.Now;
            id = deviceId;
        }
        

        public string id { get => _id; set => _id = value; }
        public DateTime date { get => _date; set => _date = value; }
        public double value { get => _value; set => this._value = value; }
    }
}
