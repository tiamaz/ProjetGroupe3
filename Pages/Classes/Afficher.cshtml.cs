using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetGroupe3.Data;
using ProjetGroupe3.Model;

namespace ProjetGroupe3.Pages.Classes
{

    public class AfficherModel : PageModel
    {
        public IEnumerable<Publication> publications {get; set;}

        public Publication publication {get; set;}
        private readonly ApplicationDbContext _db;

        public AfficherModel(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public void OnGet(int IdClasse)
        {

            publications = _db.publication.Where(x => x.IdClasse == IdClasse);

        }
    }
}
