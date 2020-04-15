using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetGroupe3.Data;
using ProjetGroupe3.Model;
using ProjetGroupe3.Model.ModelView;

namespace ProjetGroupe3.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _db;

        public IEnumerable<Publication> publications;
        private readonly UserManager<IdentityUser> _userManager;

        
        public IndexModel(
            ILogger<IndexModel> logger,
               ApplicationDbContext db,
               UserManager<IdentityUser> userManager
            )
        {
            _logger = logger;
            _db = db;
            _userManager = userManager;
        }

        public async Task OnGet()
        {
            
            
            var user = await _userManager.GetUserAsync(HttpContext.User);

      //  string Id ="AAA";
            publications = await (
                from clas in _db.classe
                where clas.IdProf == user.Id
                join pub in _db.publication
                on clas.IdClasse equals pub.IdClasse
                select pub).ToListAsync();

        }
    }
}
