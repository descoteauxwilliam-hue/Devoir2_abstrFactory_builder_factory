# Devoir2_abstrFactory_builder_factory

Vous devez développer en C# (.NET) une application console qui démontre l’utilisation combinée de trois
patrons créationnels.


| Table des Matières                                  |
|:---------------------------------------------------:|
| [Objet concret](#objet-concret)                     |
| [Style des objet concret](#style-des-objet-concret) |
| [Classe compose](#classe-compose)                   |
| [Factory Method](#factory-method)                   |
| [Abstract Factory](#abstract-factory)               |
| [Builder](#builder)                                 |
| [Director](#director)                               |
| [Programme de Test](#programme-de-test)             |
| [Diagrame UML](#diagrame-uml)                       |


## Objet concret

- `House` (une maison)
- `Duplex`

## Style des objet concret

- Quebecois
- Persian
- Modern

## Modèle métier

### Les composants

1. Chaque maison et duplexe doivent être composé de :
   
    - `IBasement` (sous-sol)
    - `IStructure` (structure)
    - `IInterior` (intérieur)
    - `IRoof` (toit)
  
1. Chaque interface doit définir la méthode `void display();`

    Exemple :
   ``` c#
   public interface IBuildingComposant {
       void Display();
   }
   ```

## Variantes concretes stylés

Chaque composant doit avoir une implémentention concrete pour chaque style.  
Un total de 12 implémentation concrètes sera prodfuit ( 4 interface, 3 style )

## Factory Method

1. Les styles seront defini par un Enum :  

   ``` c#
   public enum ProductType {
       Quebecois,
       Persian,
       Modern,
   }
   ```
2. Chaque factory doit retourner une composant.  
   Donc 4 factories sera necessaire :

   - `FactoryBasement => IBasement`
   - `FactoryStructure => IStructure`
   - `FactoryInterior => IInterior`
   - `FactoryRoof => IRoof`
  
3. Chaque factory doit implementer ces methode :

   - `public static IBasement Factory(ProductType type)`
   - `public static IStructure Factory(ProductType type)`
   - `public static IInterior Factory(ProductType type)`
   - `public static IRoof Factory(ProductType type)`
  
   Exmple :

   ``` c#
   public class FactoryExample {
       public static IBasement Factory(ProductType type) => new BasementExample{ type = type };
       public static IStructure Factory(ProductType type) => new StructureExample{ type = type };
       public static IInterior Factory(ProductType type) => new InteriorExample{ type = type };
       public static IRoof Factory(ProductType type) => new RoofExample{ type = type };
   }
   ```

4. Elle doit utiliser un switch pour retourner la bonne classe concrete.

## Classe compose

### House

1. Proprietes :

   - `IBasement basement`
   - `IStructure structure`
   - `IInterior interior`
   - `IRoof roof`
  
2. Methode obligatoire :

   - `void SetBasement(ProducType type)`
   - `void SetStructure(ProducType type)`
   - `void SetInterior(ProducType type)`
   - `void SetRoof(ProducType type)`
   - `void DisplayHouse()` : appele `Display()` sur les 4 composant en suivant un ordre logique
  
``` c#
public class House {
    private IBasement basement;
    private IStructure structure;
    private IInterior interior;
    private IRoof roof;

    public void SetBasement(ProducType type) {
        // set this.basement whith a concrete basement of the chosen type
    }
    public void SetStructure(ProducType type) {
        // set this.structure whith a concrete structure of the chosen type
    }
    public void SetInterior(ProducType type) {
        // set this.interior whith a concrete interior of the chosen type
    }
    public void SetRoof(ProducType type) {
        // set this.roof whith a concrete roof of the chosen type
    }
    public void DisplayHouse() {
        // appele `Display()` sur les 4 composant en suivant un ordre logique

        /* Exemple :
         * roof.Display();
         * interior.Display();
         * structure.Display();
         * basement.Display();
         */
    }
}
```

### Duplex

1. Proprietes :

   - `IBasement basement`
   - `IStructure structure`
   - `IInterior interior`
   - `IRoof roof`
  
2. Methode obligatoire :

   - `void SetBasement(ProducType type)`
   - `void SetStructure(ProducType type)`
   - `void SetInterior(ProducType type)`
   - `void SetRoof(ProducType type)`
   - `void DisplayDuplex()` : appele `Display()` sur les 4 composant en suivant un ordre logique
  
``` c#
public class Duplex {
    private IBasement basement;
    private IStructure structure;
    private IInterior interior;
    private IRoof roof;

    public void SetBasement(ProducType type) {
        // set this.basement whith a concrete basement of the chosen type
    }
    public void SetStructure(ProducType type) {
        // set this.structure whith a concrete structure of the chosen type
    }
    public void SetInterior(ProducType type) {
        // set this.interior whith a concrete interior of the chosen type
    }
    public void SetRoof(ProducType type) {
        // set this.roof whith a concrete roof of the chosen type
    }
    public void DisplayDuplex() {
        // appele `Display()` sur les 4 composant en suivant un ordre logique

        /* Exemple :
         * roof.Display();
         * interior.Display();
         * structure.Display();
         * basement.Display();
         */
    }
}
```

## Abstract Factory

### Abstraction

Creer une classe abstraite ou une interface qui definit :

- `House MakeHouse()`
- `Duplex MakeDuplex`

Example :

``` c#
public abstract class AbstractFactory {
    public abstract House MakeHouse();
    public abstract Duplex MakeDuplex();
}
```

### Factory Concrete

1. Creer une factory concrete pour chaque style :
   
   - `QuebecoisFactory : AbstractFactory`
   - `PersianFactory : AbstractFactory`
   - `ModernFactory : AbstractFactory`

3. Chaque factory doit creer une `House` et `Duplex`.
4. Chaque factory doit appeler les setter avec le `ProducType` lui correspondant.
   Exemple :
   `QuebecoisFactory.MakeHouse()` doit contruire une `House` dont toutes le sparties sont Quebecois.

## Builder

### Interface IBuilder

1. Deux interface de Builder doivent etre defini :

   - `IHouseBuilder` : Builder de `House`
   - `IDuplexBuilder` : Builder de `Duplex`

2. Chaque interface doive contenir les methodes suivantes :

   - `void BuildBasement()`
   - `void BuildStructure()`
   - `void BuildInterior()`
   - `void BuildRoof()`
   - `House GetHouse()` ou `Duplex GetDuplex()` selon le builder

   Exemple :

   ``` c#
   public interface IBuildingBuilder {
       void BuildBasement();
       void BuildStructure();
       void BuildInterior();
       void BuildRoof();
       Building GetBuilding();
   }
   ```

### Builder Concret

1. Implementer les avec des classes concretes les builder pour chaque style et chaque type de batiments :

   - `House`

      - `QuebcoisHouseBuilder : IHouseBuilder`
      - `PersianHouseBuilder : IHouseBuilder`
      - `ModernHouseBuilder : IHouseBuilder`
  
   - `Duplex`

      - `QuebecoisDuplexBuilder : IDuplexBuilder`
      - `PersianDuplexBuilder : IDuplexBuilder`
      - `ModernDuplexBuilder : IDuplexBuilder`

2. Chaque builder contret doit :

   - Posseder une instance de l'objet en construction.
   - Utiliser les Factory pour mettre les bons composants
   - Retourner l'objet final avec `GetHouse`/`GetDuplex()`
  
## Director

Creer deux classes `Engineer` qui recoit un builder dans son constructeur :

- `HouseEngineer(IHouseBuilder builder)`
- `DuplexEngineer(IDuplexBuilder builder)`

## Programme de Test

Tester les implementation a l'interieur de la methode `Main()` de *Program.cs*.  
Il doit :

- Demontrer la creation de tous les modeles de `House` et de `Duplex`.
- Afficher les deux batiments avec `House.DiplayHouse()` et `Duplex.DisplayDuplex()`.

## Diagrame UML

### Contenu

- [x] Les interfaces des composant
   - [x] `IBasement`
   - [x] `IStructure`
   - [x] `IInterior`
   - [x] `IRoof`
- [x] Les classes concrete des composantes
   - [x] Sous-sols
      - [x] `QuebecoisBasement`
      - [x] `PersianBasement`
      - [x] `QuebecoisInterior`
   - [x] Structures
      - [x] `QuebecoisStructure`
      - [x] `PersianStructure`
      - [x] `ModernStructure`
   - [x] Interieurs
      - [x] `QuebecoisInterior`
      - [x] `PersianInterior`
      - [x] `ModernInterior`
   - [x] Toits
      - [x] `QuebecoisRoof`
      - [x] `PersianRoof`
      - [x] `ModernRoof`
- [x] Les Factories
   - [x] `FactoryBasement`
   - [x] `FactoryStructure`
   - [x] `FactoryInterior`
   - [x] `FactoryRoof`
- [x] Les Batiments
   - [x] `House`
   - [x] `Duplex`
- [x] Abstract Factory
   - [x] `AbstractFactory`
   - [x] `QuebecoisFactory`
   - [x] `PersianFactory`
   - [x] `ModernFactory`
- [x] Builder
   - [x] Interfaces
      - [x] `IHouseBuilder`
      - [x] `IDuplexBuilder`
   - [x] Classe Concrete
      - [x] `QuebecoisHouseBuilder`
      - [x] `PersianHouseBuilder`
      - [x] `ModernHouseBuilder`
      - [x] `QuebecoisDuplexBuilder`
      - [x] `PersianDuplexBuilder`
      - [x] `ModernDuplexBuilder`
- [x] Engineer
   - [x] `HouseEngineer`
   - [x] `DuplexEngineer`
     
### Relation

Le diagramme doit montrer les relations entre entites suivantes :

- Heritage (implements/extends)
- Dependances (use)
- Composition
- Aggregation

-------------------------------------------------------------------------------------------------------------------
### data
#### building component
- [x] Implementation des interfaces (IBasement, IStructure, IInterior, IRoof)
- [x] Implementation des subclass des interfaces 

#### building (house, duplex)
- [x] Implementation des champs (IBasement, IStructure, IInterior, IRoof)
- [x] Implementation des setters


### Factory method
- [x] Implementations des FactoryMethods et du switch case

### Abstract Factory

- [x] Implementation de l'interface IAbstractFactory
- [x] Implementation de subclass {QuebecoisFactory, PersianFactory, ModernFactory}

### Builder

- [x] Implementation de IBuilder, IHouseBuilder et IDuplexBuilder
- [x] Implementation de directeur
      



