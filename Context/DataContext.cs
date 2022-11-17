using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectBank.Models;
using System.Data.Entity;
using DbContext = System.Data.Entity.DbContext;
using Microsoft.EntityFrameworkCore;


namespace ProjectBank.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        
    }
    public System.Data.Entity.DbSet<ListaModel> Lista { get; set; }
    public System.Data.Entity.DbSet<Usuario ListaDeUsuariosETransações { get; set; }

    public class Usuario
    {
    }
}

    
