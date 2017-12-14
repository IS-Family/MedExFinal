namespace MedEx2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Certification")]
    public partial class Certification
    {
        [Key]
        public int CertID { get; set; }

        [Required]
        [StringLength(255)]
        public string CertName { get; set; }
    }
}
