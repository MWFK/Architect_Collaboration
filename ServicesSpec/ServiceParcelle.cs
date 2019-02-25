using Data.Infrastructure;
using ParcelleDeTerre.Domaine.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesSpec
{
    public class ServiceParcelle:Service<ParcelleTerre>,IServiceParcelle
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);
        public ServiceParcelle():base(ut)
        {

        }

    }
}
