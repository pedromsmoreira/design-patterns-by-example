# What is this Pattern ?

## Chain of Responsibility Pattern

This pattern belongs to the Behavioral group of patterns.

Helps avoid coupling between sender and receiver. 

Creates a sequential chain of receivers. It passes a request between different receivers in sequential chain until the righ receiver is met.

> Useful: Uncommon. 

> What it is good for? Allows multiple different object to possibly process a request. Scenarios such as workflows.

### Intent
 
 > Passing a request between a chain of objects.
 
### Problem
 
We want to design reusable components, but dependencies are potentially blocking the reusability.

### Participants

 * __Handler:__ This is an interface or abstract class that all classes who could handle the event should implement.
 * __ConcreteHandler:__ These objects can each handle a request, and can access their sucessor. They can propagate an event further down the chain or handle the event.
 * __Client:__ Initializes the request to a __ConcreteHandler__. This class also defines the chain sucessors for all __ConcreteHandlers__.

### Useful resources

> https://www.codeproject.com/Articles/494241/Understanding-and-Implementing-Chain-of-Responsibi

> https://www.exceptionnotfound.net/chain-of-responsibility-the-daily-design-pattern/

> http://www.c-sharpcorner.com/UploadFile/chinnasrihari/chain-of-responsibility-design-pattern/

### Bonus Pattern

## Specification Pattern

### Intent

Segregate business rules based on the Single Reponsibility Principle.

This rules can be chained together using boolean operands (__AND__, __OR__ or __NOT__) to create complex business rules.

Each rule is called Specification.