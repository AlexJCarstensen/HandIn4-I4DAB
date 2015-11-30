using System;
using Handin4GDEMDS.Database.DbSets;

namespace Handin4GDEMDS.Database
{

      public class SensorNApartmentRead
        {
            public AppartmentcharacteristicSet[] appartmentCharacteristic { get; set; }
            public DateTime timestamp { get; set; }
            public int version { get; set; }
            public SensorcharacteristicSet[] sensorCharacteristic { get; set; }
        }

       /*   public class Appartmentcharacteristic
        {
            public int No { get; set; }
            public float Size { get; set; }
            public int Floor { get; set; }
            public int appartmentId { get; set; }
        }

        public class Sensorcharacteristic
        {
            public string calibrationCoeff { get; set; }
            public string description { get; set; }
            public DateTime calibrationDate { get; set; }
            public string externalRef { get; set; }
            public int sensorId { get; set; }
            public string unit { get; set; }
            public string calibrationEquation { get; set; }
        }*/

/*    public class Reading
    {
        public int sensorId { get; set; }
        public int appartmentId { get; set; }
        public float value { get; set; }
        public DateTime timestamp { get; set; }
    }*/


}