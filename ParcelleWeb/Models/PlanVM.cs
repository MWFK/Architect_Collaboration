using ParcelleDeTerre.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParcelleWeb.Models
{
    public class PlanVM
    {

        

        [DataType(DataType.Date)]

        public DateTime DateDebut { get; set; }
        public int DureeRealisation { get; set; }
        public Etat Etat { get; set; }

        [Range(0, float.MaxValue)]

        public float Surface { get; set; }
        
        public int NombreEtages { get; set; }
        public int NombrePieces { get; set; }

        [Display(Name = "Parcelle")]
        public int NumeroParcelle { get; set; }
        
        [Display(Name ="Architecte")]
        public int NumeroArchitecte { get; set; }

        public IEnumerable<SelectListItem>  Parcelles { get; set; }
        public  IEnumerable<SelectListItem> Architectes { get; set; }

    }
}