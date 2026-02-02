using Data.v1.Building;

namespace Builder.v1;

public class HouseDirector
{
    private IHouseBuilder builder;
    public HouseDirector(IHouseBuilder builder)
    {
        this.builder = builder;
    }

    public House MakeHouse()
    {
        return builder
            .buildBasement()
            .buildStructure()
            .buildInterior()
            .buildRoof()
            .getHouse();
    }
}