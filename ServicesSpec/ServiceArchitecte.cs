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
  public  class ServiceArchitecte:Service<Architecte>, IServiceArchitecte
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public ServiceArchitecte()
           : base(ut)
        {



        }

        public int NbreProjetsEnCours(Architecte a)
        {
            return a.Plans.Where(p => p.Etat.Equals(Etat.Encours)).Count();
        }

        public int NbreProjetsAnnee(Architecte a)
        {
            return a.Plans.Where(p => p.DateDebut.Year==DateTime.Now.Year && p.Etat.Equals(Etat.Approuvé)).Count();
        }

        public void ReAffectation(Plan p)
        {
            if (p.Etat.Equals(Etat.Désapprouvé))
            {
               var arc = (from Architecte a in GetMany()
                 where NbreProjetsAnnee(a) < 10 && NbreProjetsAnnee(a) < 5
                 select a).First();
                p.Architecte = arc;
                ut.getRepository<Plan>().Update(p);
                ut.Commit();

            }
        }
    }
}
