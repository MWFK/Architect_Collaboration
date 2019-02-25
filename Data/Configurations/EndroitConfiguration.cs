using ParcelleDeTerre.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
  public class EndroitConfiguration: ComplexTypeConfiguration<Endroit>
    {
        public EndroitConfiguration()
        {
            Property(p => p.Num).IsRequired();
            Property(p => p.Rue).IsRequired().HasMaxLength(20);
            Property(p => p.Ville).IsRequired().HasMaxLength(20);
        }
    }
}
