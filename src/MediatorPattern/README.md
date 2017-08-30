# What is this Pattern ?

## Mediator Pattern

This pattern belongs to the Behavioral group of patterns.

Allows multiple objects to communicate with each other without knowing each other. 

This pattern promotes loose coupling which gives an easy maintainability. 

He encapsulates how the objects will interact.

> Useful: Medium. 

> What it is good for? Defining how objects interact wit each other.

### Intent
 
 > Define an object that encapsulates how a set of objects communicate.

 > Promote loose coupling by keeping objects from referring each other explicitly.

 > Lets you vary their communication/interaction independently.
 
 > Design an intermediary to decouple many objects.
 
 > Promotes the many to many relationships between interacting objects.
 
### Problem
 
We want to design reusable components, but dependencies are potentially blocking the reusability.

### Participants

 * __Mediator:__ This is an interface that defines operations that can be called by colleague objects to communicate.
 * __ConcreteMediator:__ Implements the communication operations of the __Mediator__.
 * __Colleague:__ Defines a single, protected field that holds a reference to a mediator.
 * __ConcreteColleague:__ Classes/Objects that communicate with each other via mediator.

### Useful resources

> https://www.infoworld.com/article/3204528/application-development/how-to-use-the-mediator-design-pattern-in-c.html

> http://www.dotnettricks.com/learn/designpatterns/mediator-design-pattern-c-sharp

> https://sourcemaking.com/design_patterns/mediator