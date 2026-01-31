using System.Diagnostics;

MainV1();
MainV2();

static void MainV1()
{

}


static void MainV2()
{
    Builder.v2.Director director;
    Data.v2.Building.IBuilding building;
    //----------- testing house builders -----------//
    Builder.v2.HouseBuilder Housebuilder;

    //Quebecois house
    Housebuilder = new Builder.v2.HouseBuilder(new AbstractFactory.v2.QuebecoisFactory());
    director = new Builder.v2.Director(Housebuilder);
    building = director.build();

    Debug.Assert("This house as: quebecois basement, quebecois structure, quebecois interior, quebecois roof" == building.Display());

    //Persian house
    Housebuilder = new Builder.v2.HouseBuilder(new AbstractFactory.v2.PersianFactory());
    director = new Builder.v2.Director(Housebuilder);

    building = director.build();
    Debug.Assert("This house as: persian basement, persian structure, persian interior, persian roof" == building.Display());


    //modern house
    Housebuilder = new Builder.v2.HouseBuilder(new AbstractFactory.v2.ModernFactory());
    director = new Builder.v2.Director(Housebuilder);

    building = director.build();
    Debug.Assert("This house as: modern basement, modern structure, modern interior, modern roof" == building.Display());




    //----------- testing duplex builders -----------//
    Builder.v2.DuplexBuilder Duplexbuilder;

    //Quebecois house
    Duplexbuilder = new Builder.v2.DuplexBuilder(new AbstractFactory.v2.QuebecoisFactory());
    director = new Builder.v2.Director(Duplexbuilder);

    building = director.build();
    Debug.Assert("This duplex as: quebecois basement, quebecois structure, quebecois interior, quebecois roof" == building.Display());

    //Persian house
    Duplexbuilder = new Builder.v2.DuplexBuilder(new AbstractFactory.v2.PersianFactory());
    director = new Builder.v2.Director(Duplexbuilder);

    building = director.build();
    Debug.Assert("This duplex as: persian basement, persian structure, persian interior, persian roof" == building.Display());


    //modern house
    Duplexbuilder = new Builder.v2.DuplexBuilder(new AbstractFactory.v2.ModernFactory());
    director = new Builder.v2.Director(Duplexbuilder);

    building = director.build();
    Debug.Assert("This duplex as: modern basement, modern structure, modern interior, modern roof" == building.Display());
}
