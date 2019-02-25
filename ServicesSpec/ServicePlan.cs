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
   public class ServicePlan:Service<Plan>,IServicePlan
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public ServicePlan()
           : base(ut)
        {
            
        }

       public float CoutTotalPlan(Plan p)
        {
            float sum = 500 + p.NombrePieces * 50;
            if (p.Architecte.NombresAnneesExperiences > 5)
                sum += 200;
            if (p.Surface > 200)
                sum += 100;

                return sum;
        }
    }
}
