using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelleDeTerre.Domaine.Entities
{
    public class ParcelleTerre
    {
        public int NumeroParcelle { get; set; }
        [Range(0, float.MaxValue)]
        public float Surface { get; set; }
        public Endroit Endroit { get; set; }
        public string NatureDuSol { get; set; }
        #region prop navig
        public virtual ICollection<Plan> Plans { get; set; }
        #endregion

    }
}
