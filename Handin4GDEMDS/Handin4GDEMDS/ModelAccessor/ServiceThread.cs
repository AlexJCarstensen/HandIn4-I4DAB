using System;
using System.Threading;

namespace Handin4GDEMDS.ModelAccessor
{
    public class ServiceThread
    {
        public static event EventHandler DataArrivedEvent;
        private readonly ModelAccess Model;
        private readonly int _maxRead;

        public ServiceThread()
        {
            _maxRead = 11803;
            Model = new ModelAccess();
        }

        public void Run()
        {

            var getter = 1;
            while (true)
            {
                Thread.Sleep(1000);
                if (getter > _maxRead) getter = 1;
                
                Model.ReadSensorData(getter);
                getter++;

                OnDataArrivedEvent();

                Thread.Sleep(4 * 1000);
            }
        }

        private static void OnDataArrivedEvent()
        {
            DataArrivedEvent?.Invoke(null, EventArgs.Empty);
        }
    }
}