using EjemploRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EjemploRazor.Controllers
{
    public class PlantillaController : Controller
    {
        ModeloPlantilla modelo;
        // GET: Plantilla
        public PlantillaController()
        {
            this.modelo = new ModeloPlantilla();
        }

        public ActionResult Ejemplo1()
        {
            ViewBag.Mensaje = "Hola mundo";
            return View();
        }
        public ActionResult Ejemplo2()
        {
            MADRID jugador = modelo.GetJugador();
            return View(jugador);
        }
        public ActionResult Ejemplo3()
        {
            List<MADRID> lista = modelo.GetPlantilla();
            return View(lista);
        }
        public ActionResult Plantilla()
        {
            List<MADRID> lista = modelo.GetPlantilla();
            return View(lista);
        }
        public ActionResult Details(int dorsal)
        {
            MADRID jugador = modelo.GetDetalles(dorsal);
            return View(jugador);
        }
    }
}