
using Data.v1.Building;
using Data.v1.Product.Basement;
using Data.v1.Product.Interior;
using Data.v1.Product.Roof;
using Data.v1.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;
using Builder.v1;

namespace AbstractFactory.v1
{
    internal class ModernFactory : IAbstractFactory
    {
        public Duplex makeDuplex()
        {
            return new DuplexDirector(
                    new ModernDuplexBuilder()
                ).MakeDuplex();
        }

        public House makeHouse()
        {
            return new HouseDirector(
                    new ModernHouseBuilder()
                ).MakeHouse();
        }
    }
}
