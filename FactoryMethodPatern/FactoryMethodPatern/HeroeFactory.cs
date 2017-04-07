using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatern
{
    public class HeroeFactory:Factory
    {
        public override IHeroe GetHeroe(string Heroe)
        {
            switch (Heroe)
            {
                case "Draven":
                    return new Draven();
                case "Twitch":
                    return new Twitch();
                case "Teemo":
                    return new Teemo();
                default:
                    throw new ApplicationException(string.Format("The heroe {0} couldn't be created.", Heroe));
            }
        }
    }
}
