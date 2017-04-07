using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroeFactory FabricaDeHeroes = new HeroeFactory();
            
            try
            {
                IHeroe heroe = FabricaDeHeroes.GetHeroe("Teemo");
                heroe.BattleCry();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }

            Console.ReadKey();
        }
    }
}
