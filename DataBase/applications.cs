namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class applications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public applications()
        {
            procurements = new HashSet<procurements>();
        }

        [Key]
        public int applicationId { get; set; }

        public int pharmacyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime applicationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime applicationCompletionDate { get; set; }

        public virtual pharmacies pharmacies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<procurements> procurements { get; set; }
    }
}
