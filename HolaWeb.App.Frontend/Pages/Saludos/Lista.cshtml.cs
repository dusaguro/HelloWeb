using System.Collections;
using System.Collections.Generic;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages.Saludos
{
    public class Lista : PageModel
    {
        private readonly IRepSaludos _saludos = new RepSaludos(new AppDbContext());
        public IEnumerable<Dominio.Saludos> saluditos { get; set; }
        
        public void OnGet()
        {
            saluditos = _saludos.GetAllSaludos();
        }
    }
}