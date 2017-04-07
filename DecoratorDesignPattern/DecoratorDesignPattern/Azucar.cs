using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Azucar:IProducto
    {
        public string Descripcion()
        {
            return "Leche";
        }

        public int Precio()
        {
            return 100;
        }
    }
}
