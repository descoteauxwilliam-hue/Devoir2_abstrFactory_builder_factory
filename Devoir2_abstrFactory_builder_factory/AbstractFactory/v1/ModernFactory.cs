
using Data.v1.Building;
using Data.v1.Product.Basement;
using Data.v1.Product.Interior;
using Data.v1.Product.Roof;
using Data.v1.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v1
{
    internal class ModernFactory : IAbstractFactory
    {
        public Duplex makeDuplex()
        {
            return new Duplex();
        }

        public House makeHouse()
        {
            return new House();
        }
    }
}
