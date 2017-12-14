using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedExFinal.Models
{
    [Table("Certification")]
    public class Certificate
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CertID { get; set; }
        public String CertName { get; set; }
    }
}