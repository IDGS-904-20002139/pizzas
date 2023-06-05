using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace pizzas.Models
{
    public class Pizza
    {
        public string nombre { set; get; }

        public string direccion { set; get; }

        public string telefono { set; get; }

        public DateTime fecha { set; get; }
        public double total { get; set; }

        public int tipoPizza { set; get; }

        public int numPizzas { set; get; }

        public string resultado { set; get; }

        public Ingrediente ingrediente { get; set; }

        public int valorTotal { get; set; }

        public string detalleIngredientes { set; get; }

        public string detalleTamano { set; get; }

        public List<String> arregloDatos = new List<string>();

        public class Ingrediente
        {
            public bool Jamon { get; set; }
            public bool Pina { get; set; }
            public bool Champinon { get; set; }
        }

        public void ResultadoCompra()
        {
            int valorTamaño = 0;
            int valorIngrediente = 0;

            if (this.tipoPizza == 1)
            {
                valorTamaño = 40;
                valorIngrediente = (this.ingrediente.Jamon ? 10 : 0) + (this.ingrediente.Pina ? 10 : 0) + (this.ingrediente.Champinon ? 10 : 0);
                this.valorTotal = (valorTamaño + valorIngrediente) * this.numPizzas;
                this.detalleIngredientes = (this.ingrediente.Jamon ? "Jamón " : "") + " " + (this.ingrediente.Pina ? "Piña " : "") + " " + (this.ingrediente.Champinon ? "Champiñon" : "");
                this.detalleTamano = "Chica";
                var arregloDatos = this.detalleTamano + "," + this.detalleIngredientes + "," + this.numPizzas + "," + this.valorTotal;
                this.arregloDatos.Add(arregloDatos);
            }
            if (this.tipoPizza == 2)
            {
                valorTamaño = 80;
                valorIngrediente = (this.ingrediente.Jamon ? 10 : 0) + (this.ingrediente.Pina ? 10 : 0) + (this.ingrediente.Champinon ? 10 : 0);
                this.valorTotal = (valorTamaño + valorIngrediente) * this.numPizzas;
                this.detalleIngredientes = (this.ingrediente.Jamon ? "Jamón " : "") + " " + (this.ingrediente.Pina ? "Piña " : "") + " " + (this.ingrediente.Champinon ? "Champiñon" : "");
                this.detalleTamano = "Mediana";
                var arregloDatos = this.detalleTamano + "," + this.detalleIngredientes + "," + this.numPizzas + "," + this.valorTotal;
                this.arregloDatos.Add(arregloDatos);

            }
            if (this.tipoPizza == 3)
            {
                valorTamaño = 120;
                valorIngrediente = (this.ingrediente.Jamon ? 10 : 0) + (this.ingrediente.Pina ? 10 : 0) + (this.ingrediente.Champinon ? 10 : 0);
                this.valorTotal = (valorTamaño + valorIngrediente) * this.numPizzas;
                this.detalleIngredientes = (this.ingrediente.Jamon ? "Jamón " : "") + " " + (this.ingrediente.Pina ? "Piña " : "") + " " + (this.ingrediente.Champinon ? "Champiñon" : "");
                this.detalleTamano = "Grande";
                var arregloDatos = this.detalleTamano + "," + this.detalleIngredientes + "," + this.numPizzas + "," + this.valorTotal;
                this.arregloDatos.Add(arregloDatos);
            }
        }
    }
}