using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class ProductA : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operation of ProductA");
        }
    }
}
