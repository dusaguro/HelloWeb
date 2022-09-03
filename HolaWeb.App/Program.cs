using System;
using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;

namespace HolaWeb.App
{
    class Program
    {
        private static IRepSaludos _saludos = new RepSaludos(new AppDbContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*var j = new Saludos
            {
                Español = "Hola!",
                Ingles = "Hello!",
                Frances = "Salut!"
            };
            _saludos.AddSaludo(j);*/
            //_saludos.DelSaludo(4);
        }
    }
}