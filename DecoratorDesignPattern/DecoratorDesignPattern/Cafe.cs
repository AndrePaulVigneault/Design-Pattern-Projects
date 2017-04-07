using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class Cafe:IProducto
    {
        public List<IProducto> Ingredientes{get;set;}

        public Cafe() {
            this.Ingredientes = new List<IProducto>();
        }

        public string Descripcion() {
            string ProductoFinal = "Cafe";
            foreach (IProducto prod in Ingredientes) {
                ProductoFinal += string.Format(" con {0}", prod.Descripcion());
            }
            return ProductoFinal;
        }

        public int Precio() {
            int ProductoFinal = 300;
            foreach (IProducto prod in Ingredientes)
            {
                ProductoFinal += prod.Precio();
            }
            return ProductoFinal;
        }
    }
}
