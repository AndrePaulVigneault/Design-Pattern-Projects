using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatern
{
    public class Draven:IHeroe
    {
        public void BattleCry() {
            Console.WriteLine("I am Draven!!!!!");
        }
    }
}
