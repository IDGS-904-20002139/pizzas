using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace pizzas.Services
{
    public class LeerPizza
    {
        public Array LeerArchivo()
        {
            Array pizzas = null;
            var inforMaes = HttpContext.Current.Server.MapPath("~/App_Data/pizza.txt");
            if (File.Exists(inforMaes))
            {
                pizzas = File.ReadAllLines(inforMaes);
            }
            return pizzas;
        }
    }
}