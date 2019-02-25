using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelleDeTerre.Domaine.Entities
{
    public class Architecte
    {
        public int NumeroArchitecte { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Telephone { get; set; }

        [Range(2,int.MaxValue,ErrorMessage ="Experience minimum 2ans")]
        public int NombresAnneesExperiences { get; set; }

        public int NombreProjetsEncours { get; set; }

        public int NombresProjetsParAnnée { get; set; }

        #region prop navig
        public virtual ICollection<Plan> Plans { get; set; }
        #endregion

    }
}
