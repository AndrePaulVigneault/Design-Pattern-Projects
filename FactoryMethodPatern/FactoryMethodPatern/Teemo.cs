using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatern
{
    public class Teemo:IHeroe
    {
        public void BattleCry()
        {
            Console.WriteLine("Puff Puff.... (Hide)");
        }
    }
}
