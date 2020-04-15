using System.Collections.Generic;

namespace ProjetGroupe3.Model.ModelView
{
    public class UtilisateurClasseModelView
    {
        public IEnumerable<Classe> classes { get; set; }
        public Utilisateur utilisateur { get; set; }
    }
}