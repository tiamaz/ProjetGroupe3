using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetGroupe3.Data;
using ProjetGroupe3.Model;

namespace ProjetGroupe3.Pages.Classes
{
   [Authorize]
    public class AjouterModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        [BindProperty]
        public Classe classe {get; set;}

        public AjouterModel(
            ApplicationDbContext db,
            UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task OnGet()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            classe = new Classe();
            classe.NombreEtudiant = 0;
            classe.IdProf = user.Id;

        }

        public IActionResult OnPost(){

            if(ModelState.IsValid)
            {
                _db.classe.Add(classe);
                _db.SaveChanges();
                return RedirectToPage("index");
            }
            return Page();
        }
    }
}
