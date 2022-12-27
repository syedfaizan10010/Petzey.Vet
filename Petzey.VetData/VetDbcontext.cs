using Microsoft.EntityFrameworkCore;
using Petzey.Vet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Petzey.Vet.Data

{
    public class VetDbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
        DbSet <Doctor> Doctors { get; set; }
    }
}
