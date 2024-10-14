using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class FactoryB : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
