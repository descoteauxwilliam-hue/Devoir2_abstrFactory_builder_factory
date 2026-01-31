using Data.v1.Product.Basement;
using Data.v1.Product.Interior;
using Data.v1.Product.Roof;
using Data.v1.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.v1.Building
{
    internal class Duplex
    {
        IBasement basement;
        IStructure structure;
        IInterior interior;
        IRoof roof;
        
        public void setBasement(IBasement basement)
        {
            this.basement = basement;
        }

        public void setStructure(IStructure structure)
        {
            this.structure = structure;
        }
        public void setInterior(IInterior interior)
        {
            this.interior = interior;  
        }

        public void setRoof(IRoof roof)
        {
            this.roof = roof;
        }
        public string Display()
        {
            return $"This duplex as: {basement.display()}, {structure.display()}, {interior.display()}, {roof.display()}";
        }
    }
}
