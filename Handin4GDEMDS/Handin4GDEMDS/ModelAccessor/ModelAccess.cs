using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Handin4GDEMDS.Database;
using Handin4GDEMDS.Database.DbSets;


namespace Handin4GDEMDS.ModelAccessor
{
    public class ModelAccess
    {
        /// <summary>
        /// reads all sensor and appartment info and saves them in db
        /// </summary>
        public void ReadData()
        {
            var O =
                JsonStringToObject<SensorNApartmentRead>.Convert(
                    HttpGetAction.Get("http://userportal.iha.dk/~jrt/i4dab/E14/HandIn4/GFKSC002_original.txt"));

            using (var context = new Handin4DatabaseContext())
            {
                foreach (var a in O.appartmentCharacteristic)
                {
                    context.AppartmentcharacteristicSet.Add(a);
                }
                foreach (var s in O.sensorCharacteristic)
                {
                    context.SensorcharacteristicSet.Add(s);
                }
                context.SaveChanges();
            }
        }

        public bool ReadSensorData(int number)
        {
            var O =
                JsonStringToObject<SensorRead>.Convert(
                    HttpGetAction.Get($"http://userportal.iha.dk/~jrt/i4dab/E14/HandIn4/dataGDL/data/{number}.json"));

            using (var context = new Handin4DatabaseContext())
            {
                foreach (var a in O.reading)
                {
                    if (context.AppartmentcharacteristicSet.Any(t => t.appartmentId == a.appartmentId))
                    {
                        context.ReadingSet.Add(a);
                    }
                }
                context.SaveChanges();
            }

            return true;
        }

        public ObservableCollection<ReadingSet> GetSensorRead(int sensorId)
        {
            using (var context = new Handin4DatabaseContext())
            {
                return new ObservableCollection<ReadingSet>(context.ReadingSet.Where(t => t.SensorID == sensorId));  
            }
        }

        public ObservableCollection<SensorcharacteristicSet> GetSensors()
        {
            using (var context = new Handin4DatabaseContext())
            {
                return new ObservableCollection<SensorcharacteristicSet>(context.SensorcharacteristicSet);
            }
        } 

    }
}