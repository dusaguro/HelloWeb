using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepSaludos : IRepSaludos
    {
        private readonly AppDbContext _appDbContext;

        public RepSaludos(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Saludos> GetAllSaludos()
        {
            return _appDbContext.Saluditos;
        }

        public Saludos AddSaludo(Saludos saludo)
        {
            var saludoagregado = _appDbContext.Saluditos.Add(saludo);
            _appDbContext.SaveChanges();
            return saludoagregado.Entity;
        }

        public Saludos GetSaludo(int idsaludo)
        {
            return _appDbContext.Saluditos.FirstOrDefault(s => s.Id == idsaludo);
        }

        public Saludos UpSaludo(Saludos saludo)
        {
            throw new System.NotImplementedException();
        }

        public void DelSaludo(int idsaludo)
        {
            var saludoencontrado = _appDbContext.Saluditos.FirstOrDefault(s => s.Id == idsaludo);
            if (saludoencontrado==null)
            {
                return;
            }

            _appDbContext.Saluditos.Remove(saludoencontrado);
            _appDbContext.SaveChanges();
        }
    }
}