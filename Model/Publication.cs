using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetGroupe3.Model
{
    public class Publication
    {
        [Key]
        public int IdPublication { get; set; }

        [Required]
        public string Contenu { get; set; }

        [Required]
        public string DatePublication { get; set; }

        [Required]
        public int IdClasse { get; set; }


        [ForeignKey("IdClasse")]
        public Classe classe { get; set; }
    }
}