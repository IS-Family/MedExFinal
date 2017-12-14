using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedExFinal.Models
{
    [Table("CompletedCert")]
    public class CompletedCert
    {
        [Key]
        public int id { get; set; }
        
        public int? CertID { get; set; }
        [ForeignKey("CertID")]
        public virtual Certificate Certificates { get; set; }
        
        public int? DoctorID { get; set; }
        [ForeignKey("DoctorID")]
        public virtual Doctor Doctors { get; set; }

        public byte[] FilePath { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}