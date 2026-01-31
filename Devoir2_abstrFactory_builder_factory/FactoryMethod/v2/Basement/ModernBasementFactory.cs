using Data.v2.Product.Basement;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.v2.Basement
{
    internal class ModernBasementFactory : IBasementCreator
    {
        public IBasement FactoryMethod()
        {
            return new ModernBasement();
        }
    }
}
