//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HandIn4Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SensorcharacteristicSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SensorcharacteristicSet()
        {
            this.ReadingSets = new HashSet<ReadingSet>();
        }
    
        public int SensorID { get; set; }
        public System.DateTime calibrationDate { get; set; }
        public string description { get; set; }
        public string externalRef { get; set; }
        public string calibrationEquation { get; set; }
        public string calibrationCoeff { get; set; }
        public string unit { get; set; }
        public Nullable<int> Appartmentcharacteristic_appartmentId { get; set; }
    
        public virtual AppartmentcharacteristicSet AppartmentcharacteristicSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReadingSet> ReadingSets { get; set; }
    }
}
