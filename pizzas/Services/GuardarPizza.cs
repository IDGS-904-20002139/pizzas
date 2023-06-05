using pizzas.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace pizzas.Services
{
    public class GuardarPizza
    {
        public void GuardaArchivoPizza(Pizza p)
        {
            p.ResultadoCompra();
            var valorTotal = p.valorTotal;
            var detalleTamanio = p.detalleTamano;
            var detalleIngredientes = p.detalleIngredientes;
            var numeroPizza = p.numPizzas;
            var datosTraductor = detalleTamanio + "," + detalleIngredientes + "," + numeroPizza + "," + valorTotal + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/pizza.txt");
            File.AppendAllText(archivo, datosTraductor);
        }
    }
}