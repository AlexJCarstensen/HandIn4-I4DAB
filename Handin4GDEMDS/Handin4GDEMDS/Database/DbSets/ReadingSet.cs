namespace Handin4GDEMDS.Database.DbSets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReadingSet")]
    public partial class ReadingSet
    {
        public int Id { get; set; }

        public double value { get; set; }

        public DateTime timestamp { get; set; }

        public int SensorID { get; set; }
        public virtual SensorcharacteristicSet SensorcharacteristicSet { get; set; }

        public int appartmentId { get; set; }
        public virtual AppartmentcharacteristicSet AppartmentcharacteristicSet { get; set; }
    }
}
