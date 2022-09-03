using HolaWeb.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class AppDbContext : DbContext
    {
        public DbSet<Saludos> Saluditos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SaludosDB");
            }
        }
    }
}