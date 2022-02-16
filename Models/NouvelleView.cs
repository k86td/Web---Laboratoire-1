using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laboratoire_1.Models
{
    [MetadataType(typeof(NouvelleView))]
    public partial class Nouvelle 
    { }

    public class NouvelleView
    {
        [Display(Name = "Titre de la nouvelle"), Required(ErrorMessage = "Requis")]
        public string Titre { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date de l'ajout"), Required(ErrorMessage = "Requis")]
        public string DateAjout { get; set; }

        [Display(Name = "Texte de la nouvelle"), Required(ErrorMessage = "Requis")]
        public string Texte { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Url vers l'image"), Required(ErrorMessage = "Requis")]
        public string ImageUrl { get; set; }

    }
}