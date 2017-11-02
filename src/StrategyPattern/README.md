# What is this Pattern ?

## Strategy

This pattern belongs to the Behavioral group of patterns.

It defines a family of algorithms, encapsulates each one and makes them interchangeable. 

The pattern lets the algorithm vary independently from those who use it.

> Useful: Very. 

> What it is good for? Allows multiple algorithms to vary at runtime.

### Intent
 
 > Allow the reuse of behavior without hiding. It also allows to easily extends and modify existing and new behaviors.
 
### Problem
 
We want to design reusable components, but dependencies are potentially blocking the reusability.

### Participants

 * __Strategy:__ This is an interface which is implemented by all supported algorithms/behaviors.
 * __ConcreteStrategy:__ These objects implement the algorithm/behavior defined by the __Strategy__.
 * __Context:__ Maintain a reference to a __Strategy__ object and uses this reference to call a __ConcreteStrategy__.

### Useful resources

> https://www.exceptionnotfound.net/strategy-the-daily-design-pattern/

