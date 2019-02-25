using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelleDeTerre.Domaine.Entities
{
    public enum Etat {Encours,Approuvé,Désapprouvé}
    public class Plan
    {

        [Key, Column(Order = 0)]

        [DataType(DataType.Date)]

        public DateTime DateDebut { get; set; }
        public int DureeRealisation { get; set; }
        public Etat Etat { get; set; }

        [Range(0, float.MaxValue)]

          public float Surface { get; set; }
       // public string ImageName { get; set; }
        public int NombreEtages { get; set; }
        public int NombrePieces { get; set; }
        // prop navig
        [Key, Column(Order = 1)]

        public int NumeroParcelle { get; set; }
        [Key, Column(Order = 2)]

        public int NumeroArchitecte { get; set; }

        public virtual ParcelleTerre Parcelle { get; set; }
        public virtual Architecte Architecte { get; set; }

    }
}
