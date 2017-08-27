# What is this Pattern ?

## Factory Methd

The Factory Method pattern belong to the Creational group of patterns.
It defines an interface for creating an object without specifiyng individual implementations of that interface.

With this pattern you can define common methods and properties to all the objects created by the Factory Method.
Each individual Factory Method lets you define what specific objects they will instantiate

> Useful: Extremely.
> What it is good for? Creating objects in a related family.

### Participants

 * __Product:__ Defines the interface of object the factory will create.
 * __ConcreteProduct:__ Has the objects that implement the __Product__ interface.
 * __Creator:__ Declares the _factory method_, which returns an object of type __Product__. 
			The __Creator__ can also define a default implementation of teh _factory method_.
 * __ConcreteCreator:__ Has the objects that override the _factory method_ to return an instance of a __ConcreteProduct__.