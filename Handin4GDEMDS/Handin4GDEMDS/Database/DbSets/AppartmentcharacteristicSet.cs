namespace Handin4GDEMDS.Database.DbSets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppartmentcharacteristicSet")]
    public partial class AppartmentcharacteristicSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppartmentcharacteristicSet()
        {
            ReadingSet = new HashSet<ReadingSet>();
            SensorcharacteristicSet = new HashSet<SensorcharacteristicSet>();
        }

        [Key]
        public int appartmentId { get; set; }

        public int No { get; set; }

        public double Size { get; set; }

        public int Floor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReadingSet> ReadingSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SensorcharacteristicSet> SensorcharacteristicSet { get; set; }
    }
}
