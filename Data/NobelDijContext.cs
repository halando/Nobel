using Microsoft.EntityFrameworkCore;
using Nobel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel.Data
{
    internal class NobelDijContext :DbContext
    {
        public DbSet<Dij> Dijak { get; set; }

        public DbSet<Fajta> Tipusok {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=NobeleKituntetesek;Trusted_Connection=True;"));
        }
    }
}
