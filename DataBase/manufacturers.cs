namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class manufacturers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public manufacturers()
        {
            medicines = new HashSet<medicines>();
        }

        [Key]
        public int manufacturerId { get; set; }

        [Required]
        public string manufacturerName { get; set; }

        [Required]
        public string manufacturerAddress { get; set; }

        [StringLength(17)]
        public string manufacturerPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medicines> medicines { get; set; }
    }
}
