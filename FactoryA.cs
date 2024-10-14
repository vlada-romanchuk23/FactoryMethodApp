using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class FactoryA : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}