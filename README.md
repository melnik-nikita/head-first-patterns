# Design Patterns in .Net

1. [SOLID Principles](#SOLID-Principles)
2. [Builder pattern](#Builder-pattern)

## SOLID Principles [Cheat Sheet](http://sergeyteplyakov.blogspot.com/2014/10/solid.html)

- Single responsibility principle
    - any particular class should have a single reason to change
    - Separation of concerns - different classes handling different, independent tasks/problems
    - [Teplyakov's explanation](http://sergeyteplyakov.blogspot.com/2014/08/single-responsibility-principle.html)
- Open-Closed principle
    - parts of the system or subsystem should be open for extensions but closed for modification
    - [Teplyakov's explanation](http://sergeyteplyakov.blogspot.ca/2014/08/open-closed-principle.html)
- Liskov substitution principle
    - an object (such as a class) and a sub-object (such as a class that extends the first class) must be
      interchangeable without breaking the program
    - [Teplyakov's explanation](http://sergeyteplyakov.blogspot.ca/2014/09/liskov-substitution-principle.html)
- Interface segregation principle
    - no code should be forced to depend on methods it does not use
    - YAGNI - you ain't going to need it
    - [Teplyakov's explanation](http://sergeyteplyakov.blogspot.com/2014/08/interface-segregation-principle.html)
- Dependency inversion principle
    - high-level modules should not depend upon low-level ones; it should depend on abstrations
    - [Teplyakov's explanation](http://sergeyteplyakov.blogspot.com/2014/09/the-dependency-inversion-principle.html)

## Builder pattern

The Builder pattern separates the construction of a complex object from its representation so the same construction
process can create different objects. The Builder pattern allows a client object to construct a complex object by
specifying only its type and content. The client is shielded from the details of the object's construction. This
simplifies the creation of complex objects by defining a class that builds instances of another class. The Builder
pattern produces one main product and there might be more than one class in the product, but there is always one main
class. When you use the Builder pattern, you create the complex objects one step at a time. Other patterns build the
object in a single step.

### Benefits of the Builder Pattern

1. Allows you to vary a product's internal representation.
2. Isolates code for construction and representation.
3. Gives you greater control over the construction process.

### When To Use:

1. The algorithm for creating a complex object should be independent of both the parts that make up the objects and how
   these parts are assembled.
2. The construction process must allow different representations of the constructed object.