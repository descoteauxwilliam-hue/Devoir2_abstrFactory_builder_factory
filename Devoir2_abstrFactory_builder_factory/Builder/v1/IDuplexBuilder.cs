using Data.v1.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.v1
{
    public interface IDuplexBuilder
    {
        public IDuplexBuilder buildBasement();
        public IDuplexBuilder buildStructure();
        public IDuplexBuilder buildInterior();
        public IDuplexBuilder buildRoof();
        public Duplex getDuplex();
    }
}
