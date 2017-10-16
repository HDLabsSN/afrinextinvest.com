﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.AfrinextInvest.com.Identity;

namespace Web.AfrinextInvest.com.Models
{
    public class Projet
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [StringLength(60)]
        [DisplayName("Nom du projet")]
        [Required(ErrorMessage = "Vous devez mettre le nom de votre projet")]
        public string Nom { get; set; }

        // Les images du projet
        //public int ProjectImagesId { get; set; }

        // Le résumé du projet
        [StringLength(480)]
        [DisplayName("Résumé du projet")]
        [Required(ErrorMessage = "Vous devez mettre le résumé de votre projet")]
        public string Resume { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Vous devez décrire votre projet en détail")]
        public string Description { get; set; }

        [DisplayName("Pays d'activité")]
        [Required(ErrorMessage = "Vous devez sélectionner votre pays d'activité")]
        public string Pays { get; set; }

        [DisplayName("Secteur d'activité")]
        [Required(ErrorMessage = "Vous devez choisir un secteur d'activité")]
        public int SecteurId { get; set; }

        [DisplayName("Coût du projet")]
        [Required(ErrorMessage = "Vous devez mettre le budget requis pour votre projet")]
        [Range(100000, 100000000, ErrorMessage = "Votre budget doit être compris entre 100000 et 100000000 francs.")]
        [DataType(DataType.Currency)]
        public long BudgetRequis { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateCreation { get; set; }

        // Project Owner
        [ScaffoldColumn(false)]
        public string ProjectOwnerId { get; set; }

        // Etat du projet (Brouillon, En attente (Soumis_Pour validation), Validé, Rejeté, suspendu)
        [ScaffoldColumn(false)]
        public string State { get; set; }

        [ForeignKey("SecteurId")]
        public virtual SecteurActivite SecteurActvite { get; set; }

        [ForeignKey("ProjectOwnerId")]
        public virtual User ProjectOwner { get; set; }

        //[ForeignKey("ProjectImagesId")]
        //public virtual MediaProjet ProjectImages { get; set; }
    }

}
