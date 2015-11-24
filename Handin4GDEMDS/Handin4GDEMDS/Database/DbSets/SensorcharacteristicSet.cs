namespace Handin4GDEMDS.Database.DbSets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SensorcharacteristicSet")]
    public partial class SensorcharacteristicSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SensorcharacteristicSet()
        {
            ReadingSet = new HashSet<ReadingSet>();
        }

        [Key]
        public int SensorID { get; set; }

        public DateTime calibrationDate { get; set; }

        [Required]
        public string description { get; set; }

        public string externalRef { get; set; }

        public string calibrationEquation { get; set; }

        public string calibrationCoeff { get; set; }

        public string unit { get; set; }

        public int? Appartmentcharacteristic_appartmentId { get; set; }

        public virtual AppartmentcharacteristicSet AppartmentcharacteristicSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReadingSet> ReadingSet { get; set; }
    }
}
