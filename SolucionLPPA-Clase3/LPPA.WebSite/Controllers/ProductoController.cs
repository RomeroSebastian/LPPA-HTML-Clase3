using LPPA.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LPPA.WebSite.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        //ActionResult para el botón Grabar del formulario de producto
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            //Instancio un nuevo producto
            var producto = new Producto();

            //Guardo en el objeto producto los valores ingresados en cada campo del formulario
            producto.codigo = Convert.ToInt32(form["codigo"]);
            producto.nombre = form["nombre"];
            producto.descripcion = form["descripcion"];

            Dominio.Add(producto);
            
            return RedirectToAction("Index");
        }
    }
}