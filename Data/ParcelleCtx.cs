using Data.Configurations;
using Data.Conventions;
using ParcelleDeTerre.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public class ParcelleCtx:DbContext
    {
        public ParcelleCtx():base("Name=Alias")
        {

        }
        public DbSet<ParcelleTerre> Parcelles { get; set; }
        public DbSet<Architecte> Architectes { get; set; }
        public DbSet<Plan> Plans { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //If you want to remove all Convetions and work only with configuration :
            //  modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Configurations.Add(new EndroitConfiguration());
            modelBuilder.Conventions.Add(new KeyConvention());
        }
    }
}
