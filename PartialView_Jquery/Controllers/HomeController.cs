using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialView_Jquery.Models;

namespace PartialView_Jquery.Controllers
{
    public class HomeController : Controller
    {
        List<Cliente> objCliente = new List<Cliente>();
        List<Producto> objProducto = new List<Producto>();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ObtenerCliente()
        {
            Cliente cliente = new Cliente {Nombre="Ronald",Apellido="Mamani Nijana",Edad=30,MostrarNombre= "Ronald Mamani Nijana",Profesion="Contador" };
            objCliente.Add(cliente);
            cliente = new Cliente { Nombre = "Carlos", Apellido = "Loque",Edad= 30, MostrarNombre="Carlos Luque", Profesion="Ingeniero Comercial" };
            objCliente.Add(cliente);
            return View("DetalleCliente", objCliente);
        }
        public ActionResult ObtenerProducto()
        {
            Producto producto = new Producto
            {
                Nombre = "Laptop HP",
                FechaManufactura = DateTime.Now,
                IsDisponible = true,
                Precio = 300
            };
            objProducto.Add(producto);
            producto = new Producto
            {
                Nombre = "SmartPhone",
                FechaManufactura = DateTime.Now,
                IsDisponible = true,
                Precio = 100
            };
            objProducto.Add(producto);
            producto = new Producto
            {
                Nombre = "Computadora",
                FechaManufactura = DateTime.Now,
                IsDisponible = true,
                Precio = 800
            };
            objProducto.Add(producto);
            return View("DetalleProducto", objProducto);
        }
    }
}