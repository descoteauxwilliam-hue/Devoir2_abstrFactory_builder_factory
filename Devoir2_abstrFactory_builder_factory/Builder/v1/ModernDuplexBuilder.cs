using Data.v1.Building;
using Data.v1.Product;

namespace Builder.v1;

public class ModernDuplexBuilder: IDuplexBuilder
{
    private ProductType type = ProductType.Modern;
    private Duplex duplex = new Duplex();

    public IDuplexBuilder buildBasement()
    {
        duplex.setBasement(type);
        return this;
    }
    public IDuplexBuilder buildStructure()
    {
        duplex.setStructure(type);
        return this;
    }
    public IDuplexBuilder buildInterior()
    {
        duplex.setInterior(type);
        return this;
    }
    public IDuplexBuilder buildRoof()
    {
        duplex.setRoof(type);
        return this;
    }
    public Duplex getDuplex()
    {
        return duplex;
    }
}