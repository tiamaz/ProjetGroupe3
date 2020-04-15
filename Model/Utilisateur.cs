using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ProjetGroupe3.Model
{
    public class Utilisateur : IdentityUser
    {
        [Required]
        public string Nom  { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public string Ville {get; set;}

        [Required]
        public char Status { get; set; }

    }
}