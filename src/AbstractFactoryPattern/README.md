# What is this Pattern ?

## Abstract Factory

The Abstract Factory pattern belong to the Creational group of patterns.

It is also known as Factory of Factories.

This pattern allows to define interfaces for creating families of related objects without specifying their concrete implementations.

With this pattern you create factories that return many kinds of related objects.

This pattern allows the use of __*Dependency Injection*__.

> Useful: Extremely. 

> What it is good for? Creating objects in different related families without relying on concrete implementations.

### Participants

 * __Product:__ Defines an object that will be created by the corresponding __ConcreteFactory__.
 * __AbstractProduct:__ Declares the interface for a type of product.
 * __AbstractFactory:__ Declares the interface for operations which will result in the creation of __AbstractProducts__ objects. 
			The __Creator__ can also define a default implementation of teh _factory method_.
 * __ConcreteFactory:__ Has the implementations of the operations defined in the __AbstractFactory__.
 * __Client:__ Uses the __AbstractFactory__ and __AbstractProduct__ interfaces.