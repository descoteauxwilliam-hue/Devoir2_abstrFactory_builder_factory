using Data.v1.Product.Basement;
using Data.v1.Product.Interior;
using Data.v1.Product.Roof;
using Data.v1.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;
using Data.v1.Product;
using FactoryMethod.v1;

namespace Data.v1.Building
{
    public class Duplex
    {
        IBasement basement;
        IStructure structure;
        IInterior interior;
        IRoof roof;
        
        public void setBasement(ProductType type)
        {
            this.basement = FactoryBasement.Factory(type);
        }

        public void setStructure(ProductType type)
        {
            this.structure = FactoryStructure.Factory(type);
        }
        public void setInterior(ProductType type)
        {
            this.interior = FactoryInterior.Factory(type);  
        }

        public void setRoof(ProductType type)
        {
            this.roof = FactoryRoof.Factory(type);
        }
        public string Display()
        {
            return $"This duplex as: {basement.display()}, {structure.display()}, {interior.display()}, {roof.display()}";
        }
    }
}
