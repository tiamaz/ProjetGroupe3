using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetGroupe3.Model;

namespace ProjetGroupe3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Utilisateur> utilisateur {get; set;}

        public DbSet<Classe> classe { get; set; }
        public DbSet<EtudiantClasse> etudiantClasse { get; set; }

        public DbSet<Publication> publication { get; set; }

    }
}

//dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design 
//Microsoft.EntityFrameworkCore.SqlServer
// dotnet aspnet-codegenerator identity -dc ProjetGroupe3.Data.ApplicationDbContext
