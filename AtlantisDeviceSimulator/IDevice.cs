using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantisDeviceSimulator
{
    public interface IDevice
    {
        Metric GetMetric();
        void SendMessage(string message);
    }
}
