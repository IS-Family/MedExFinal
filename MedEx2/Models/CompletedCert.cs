namespace MedEx2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompletedCert")]
    public partial class CompletedCert
    {
        public int Id { get; set; }

        public int? CertID { get; set; }

        public int? DoctorID { get; set; }

        [Required]
        [StringLength(250)]
        public string FilePath { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpirationDate { get; set; }
    }
}
