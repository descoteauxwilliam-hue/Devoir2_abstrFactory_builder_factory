using Data.v1.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.v1
{
    public interface IHouseBuilder
    {
        public IHouseBuilder buildBasement();
        public IHouseBuilder buildStructure();
        public IHouseBuilder buildInterior();
        public IHouseBuilder buildRoof();
        public House getHouse();
    }
}
