using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Cafe miCafecito = new Cafe();
            miCafecito.Ingredientes.Add(new Leche());
            miCafecito.Ingredientes.Add(new Azucar());
            Console.WriteLine("Mi producto es: {0}, y cuesta: {1}", miCafecito.Descripcion(), miCafecito.Precio());
            
            Console.ReadKey();
        }
    }
}
