using Data.v1.Building;
using Data.v1.Product;

namespace Builder.v1;

public class ModernHouseBuilder: IHouseBuilder
{
    private ProductType type = ProductType.Modern;
    private House house = new House();

    public IHouseBuilder buildBasement()
    {
        house.setBasement(type);
        return this;
    }

    public IHouseBuilder buildStructure()
    {
        house.setStructure(type);
        return this;
    }

    public IHouseBuilder buildInterior()
    {
        house.setInterior(type);
        return this;
    }

    public IHouseBuilder buildRoof()
    {
        house.setRoof(type);
        return this;
    }

    public House getHouse()
    {
        return house;
    }
}