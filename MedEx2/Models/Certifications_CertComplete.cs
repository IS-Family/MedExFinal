using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedExFinal.Models;

namespace MedEx2.Models
{
    public class Certifications_CertComplete
    {
        public IEnumerable<Certificate> Certificates { get; set; }
        public IEnumerable<CompletedCert> CompletedCerts { get; set; }
    }
}