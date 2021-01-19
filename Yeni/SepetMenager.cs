using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetMenager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " Sepete eklendi ");
        }
    }
}
