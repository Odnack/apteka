namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class procurements
    {
        public int procurementsId { get; set; }

        public int? medicinceId { get; set; }

        public int applicationId { get; set; }

        public int? quantity { get; set; }

        public virtual applications applications { get; set; }

        public virtual medicines medicines { get; set; }
    }
}
