namespace MedEx2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        public int DoctorId { get; set; }

        [Required]
        [StringLength(255)]
        public string FName { get; set; }

        [Required]
        [StringLength(255)]
        public string LName { get; set; }

        [Required]
        [StringLength(255)]
        public string DocAddress { get; set; }

        [Required]
        [StringLength(255)]
        public string DocCity { get; set; }

        [Required]
        [StringLength(255)]
        public string DocState { get; set; }

        [Required]
        [StringLength(10)]
        public string DocZip { get; set; }

        [Required]
        [StringLength(20)]
        public string DocPhone { get; set; }

        [Required]
        [StringLength(255)]
        public string DocEmail { get; set; }
    }
}
