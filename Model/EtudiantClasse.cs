using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetGroupe3.Model
{
    public class EtudiantClasse
    {
        [Key]
        public int IdEtudiantClasse { get; set; }

        [Required]
        public string IdEtudiant { get; set; }

        [Required]
        public int IdClasse { get; set; }


        [ForeignKey("IdEtudiant")]
        public Utilisateur utilisateur { get; set; }

        [ForeignKey("IdClasse")]
        public Classe classe { get; set; }


    }
}