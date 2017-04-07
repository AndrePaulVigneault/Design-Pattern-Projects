using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatern
{
    public abstract class Factory
    {
        public abstract IHeroe GetHeroe(string Heroe);
    }
}
