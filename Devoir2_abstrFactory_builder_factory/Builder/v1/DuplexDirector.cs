using Data.v1.Building;

namespace Builder.v1;

public class DuplexDirector
{
    IDuplexBuilder builder;
    public DuplexDirector(IDuplexBuilder builder)
    {
        this.builder = builder;
    }
    public Duplex MakeDuplex()
    {
        return builder
            .buildBasement()
            .buildStructure()
            .buildInterior()
            .buildRoof()
            .getDuplex();
    }
}