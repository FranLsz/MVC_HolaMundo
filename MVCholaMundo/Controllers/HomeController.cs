using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;
using MVCholaMundo.Models;

namespace MVCholaMundo.Controllers
{
    public class HomeController : Controller
    {
        public List<Saludo> lista =
            new List<Saludo>()
            {
                new Saludo() {Idioma = "Es", Texto = "Buenos dias"},
                new Saludo() {Idioma = "En", Texto = "Good morning"},
                new Saludo() {Idioma = "Fr", Texto = "Bon Jour"},
                new Saludo() {Idioma = "De", Texto = "Guten morgen"},

            };

        // GET: Home
        //Resultado de una operacion realizada (MVC no soporta la sobrecarga de metodos)
        public ActionResult Index(String id)
        {

            var data = lista.FirstOrDefault(o => o.Idioma == id);

            if (data == null)
                data = lista.First(o => o.Idioma == "Es");

            //data = lista.First(o => o.Idioma == "Es");

            return View(data);
        }
    }
}