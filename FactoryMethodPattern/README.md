# Factory Method Pattern

## Description 

In object oriented programming, the factory method pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify their exact class. Rather than by calling a constructor, this is done by calling a factory method to create an object. Factory methods can either be specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes.

The Factory Method [1] design pattern is one of twenty-three well-known design patterns that describe how to solve recurring design problems to design flexible and reusable object-oriented software, that is, objects that are easier to implement, change, test, and reuse.

The Factory Method design pattern solves problems like:

How can an object be created so that subclasses can redefine its subsequent and distinct implementation?
How can an object's instantiation be deferred to a subclass?
The Factory Method design pattern describes how to solve such problems:

Define a factory method within the superclass that defers the object's creation to a subclass's factory method.
Create an object by calling a factory method instead of directly calling a constructor.
This enables the writing of subclasses that can change the way an object is created (e.g. by redefining which class to instantiate).
See also the UML class diagram below.

## Class Diagram
![diagram](https://upload.wikimedia.org/wikipedia/commons/4/43/W3sDesign_Factory_Method_Design_Pattern_UML.jpg)


## Links
[Wikipedia](https://en.wikipedia.org/wiki/Factory_method_pattern)

[Youtube](https://www.youtube.com/watch?v=EcFVTgRHJLM)