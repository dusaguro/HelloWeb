using System.Collections;
using System.Collections.Generic;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepSaludos
    {
        IEnumerable<Saludos> GetAllSaludos();
        Saludos AddSaludo(Saludos saludo);
        Saludos GetSaludo(int idsaludo);
        Saludos UpSaludo(Saludos saludo);
        void DelSaludo(int idsaludo);
    }
}