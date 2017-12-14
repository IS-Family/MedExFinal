using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedEx2.Models;

namespace MedEx2.Models
{
    public class Doctor_Certificate
    {
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<CompletedCert> CompletedCerts { get; set; }
    }
}