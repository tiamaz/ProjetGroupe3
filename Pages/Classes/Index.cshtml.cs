using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetGroupe3.Data;
using ProjetGroupe3.Model;

namespace ProjetGroupe3.Pages.Classes
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IEnumerable<Classe> classes;
        private readonly UserManager<IdentityUser> _userManager;

        
        public IndexModel(
        
               ApplicationDbContext db,
               UserManager<IdentityUser> userManager
            )
        {
      
            _db = db;
            _userManager = userManager;
        }

        public async Task OnGet()
        {

            var user = await _userManager.GetUserAsync(HttpContext.User);

            classes = await _db.classe.Where(x => x.IdProf == user.Id).ToListAsync();
        }
    }
}
