using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Conventions
{
   public class KeyConvention:Convention
    {
        public KeyConvention()
        {
            this.Properties<int>().Where(p=>p.Name.StartsWith("Numero")).Configure(c => c.IsKey());
            this.Properties().Where(p => (p.Name.Contains("Email") | p.Name.Contains("Nom") | p.Name.Contains("Prenom"))).Configure(p=>p.IsRequired());
        }
       
    }
}
