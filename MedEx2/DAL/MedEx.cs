using MedEx2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MedExFinal.Models;

namespace MedEx2.DAL
{
    public class MedExContext : DbContext
    {
        public MedExContext() : base("MedExContext")
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
    }
}