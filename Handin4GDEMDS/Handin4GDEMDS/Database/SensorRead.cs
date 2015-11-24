using System;
using Handin4GDEMDS.Database.DbSets;

namespace Handin4GDEMDS.Database
{
    public class SensorRead
    {
        public int version { get; set; }
        public DateTime timestamp { get; set; }
        public ReadingSet[] reading { get; set; }
    }
}