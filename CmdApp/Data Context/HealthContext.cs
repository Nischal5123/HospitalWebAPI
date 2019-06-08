using CmdApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmdApp.Data_Context
{
    public class HealthContext:DbContext
    {
        public HealthContext(DbContextOptions<HealthContext> options) : base(options)
        {

        }

        public DbSet<Ailment> Ailments  { get; set; }

        public DbSet<Medication> Medications { get; set; }

        public DbSet<Patient> Patients { get; set; }
    }
}
