using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantisDeviceSimulator
{
    class Unsubscriber : IDisposable
    {
        private List<IObserver<IDevice>> _observers;
        private IObserver<IDevice> _observer;

        public Unsubscriber(List<IObserver<IDevice>> observers, IObserver<IDevice> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
