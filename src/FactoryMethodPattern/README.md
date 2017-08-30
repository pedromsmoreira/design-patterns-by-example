# What is this Pattern ?

## Builder

The Builder pattern belongs to the Creational group of patterns.

This pattern separates the construction of an object from its representation.

This is done in order to allow that the same construction process can create different representations.

> Useful: Not so much. 

> What it is good for? Creating objects which need several steps to happen in order., but the steps are different for different specific implementations.

### Participants

 * __Builder:__ Defines an abstract interface for creating parts of the __Product__.
 * __ConcreteBuilder:__ Responsible for constructing and assembling parts of the product by implementing the __Builder__.
	It must keep track and define the representation it creates.
	
 * __Product:__ Represents the object being created. Includes classes for defining the parts of the object, including any interfaces for assembling the parts into the final result. 
			The __Creator__ can also define a default implementation of teh _factory method_.
 * __Director:__ Responsible for constructing an object using the __Builder__.

 

### Useful resources

> https://www.exceptionnotfound.net/builder-the-daily-design-pattern/

> http://blog.ploeh.dk/2017/08/21/generalised-test-data-builder/

> http://www.codeguru.com/columns/dotnet/.net-design-patterns-the-builder-pattern.html