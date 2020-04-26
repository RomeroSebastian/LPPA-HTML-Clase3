using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LPPA.WebSite.Models
{
    public class Dominio
    {
        //Armo una lista de productos privada
        private static List<Producto> productos = new List<Producto>();

        //Método para agregar un producto a la lista
        public static void Add(Producto producto)
        {
            productos.Add(producto);
        }

        //Método para enviar la lista de productos
        public static List<Producto> Get()
        {
            return productos;
        }

    }
}