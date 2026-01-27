# Devoir2_abstrFactory_builder_factory
Vous devez développer en C# (.NET) une application console qui démontre l’utilisation 
combinée de trois patrons créationnels :


## Diagrame UML

On vas suivre la method GoF une factory method donc nous evitons le switch

### Factory method
- [ ] enum ProduitType {quebecois, Persian, Modern}
- [ ] integration des interfaces (IBasement, IStructure, IInterior, IRoof)
- [ ] IBasementFactory  <- [QuebecoisBasementFactory, PersianBasementFactory, ModernBasementFactory   [ return IBasement
- [ ] IStructureFactory <- [QuebecoisStructureFactory, PersianStructureFactory, ModernStructureFactory[ return IStructure
- [ ] IInteriorFactory  <- [QuebecoisInteriorFactory, PersianInteriorFactory, ModernInteriorFactory   [ return IInterior
- [ ] IRoofFactory      <- [QuebecoisRoofFactory, PersianRoofFactory, ModernRoofFactory               [ return IRoof

### Builder
- [ ]
- [ ] integration des classes concretes
- [ ] integration du builder()
- [ ] 
### Abstract Factory
- [ ] 


## Program
