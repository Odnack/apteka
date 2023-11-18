namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pharmacies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pharmacies()
        {
            applications = new HashSet<applications>();
        }

        [Key]
        public int pharmacyId { get; set; }

        [Required]
        public string pharmacyName { get; set; }

        [Required]
        public string pharmacyAddress { get; set; }

        [StringLength(17)]
        public string pharmacyPhone { get; set; }

        [Required]
        public string login { get; set; }

        [Required]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<applications> applications { get; set; }
    }
}
