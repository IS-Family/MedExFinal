using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedExFinal.Models
{
    [Table("Doctor")]
    public class Doctor
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        [DisplayName("First Name")]
        public String FName { get; set; }
        [DisplayName("Last Name")]
        public String LName { get; set; }
        [DisplayName("Phone")]
        public String DocPhone { get; set; }
        [DisplayName("Address")]
        public String DocAddress { get; set; }
        [DisplayName("City")]
        public String DocCity { get; set; }
        [DisplayName("State")]
        public String DocState { get; set; }
        [DisplayName("Zip")]
        public String DocZip { get; set; }
        [DisplayName("Email")]
        [EmailAddress]
        public String DocEmail { get; set; }
    }
}