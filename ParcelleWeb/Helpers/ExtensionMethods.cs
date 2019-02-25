using ParcelleDeTerre.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParcelleWeb.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Architecte> architecteurs)
        {
            return
                architecteurs.OrderBy(ar => ar.Nom)
                      .Select(ar =>
                          new SelectListItem
                          {
                              
                              Text = ar.Prenom,
                              Value = ar.NumeroArchitecte.ToString()
                          });
        }
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<ParcelleTerre> parcelles)
        {
            return
                parcelles
                      .Select(p =>
                          new SelectListItem
                          {

                              Text = p.Endroit.Rue,
                              Value = p.NumeroParcelle.ToString()
                          });
        }
    }
}