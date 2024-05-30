# Abstract Factory Pattern

## Description 

The abstract factory pattern in software engineering is a design pattern that provides a way to create families of related objects without imposing their concrete classes, by encapsulating a group of individual factories that have a common theme without specifying their concrete classes.[1] According to this pattern, a client software component creates a concrete implementation of the abstract factory and then uses the generic interface of the factory to create the concrete objects that are part of the family. The client does not know which concrete objects it receives from each of these internal factories, as it uses only the generic interfaces of their products.[1] This pattern separates the details of implementation of a set of objects from their general usage and relies on object composition, as object creation is implemented in methods exposed in the factory interface.[2]

Use of this pattern enables interchangeable concrete implementations without changing the code that uses them, even at runtime. However, employment of this pattern, as with similar design patterns, may result in unnecessary complexity and extra work in the initial writing of code. Additionally, higher levels of separation and abstraction can result in systems that are more difficult to debug and maintain.

The abstract factory design pattern is one of the 23 patterns described in the 1994 Design Patterns book. It may be used to solve problems such as:[3]

How can an application be independent of how its objects are created?
How can a class be independent of how the objects that it requires are created?
How can families of related or dependent objects be created?
Creating objects directly within the class that requires the objects is inflexible. Doing so commits the class to particular objects and makes it impossible to change the instantiation later without changing the class. It prevents the class from being reusable if other objects are required, and it makes the class difficult to test because real objects cannot be replaced with mock objects.

A factory is the location of a concrete class in the code at which objects are constructed. Implementation of the pattern intends to insulate the creation of objects from their usage and to create families of related objects without depending on their concrete classes.[2] This allows for new derived types to be introduced with no change to the code that uses the base class.

The pattern describes how to solve such problems:

Encapsulate object creation in a separate (factory) object by defining and implementing an interface for creating objects.
Delegate object creation to a factory object instead of creating objects directly.
This makes a class independent of how its objects are created. A class may be configured with a factory object, which it uses to create objects, and the factory object can be exchanged at runtime.

## Class Diagram
![diagram](https://upload.wikimedia.org/wikipedia/commons/a/aa/W3sDesign_Abstract_Factory_Design_Pattern_UML.jpg)


## Links
[Wikipedia](https://en.wikipedia.org/wiki/Abstract_factory_pattern)

[Youtube](https://www.youtube.com/watch?v=hUE_j6q0LTQ)