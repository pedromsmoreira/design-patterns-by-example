# What is this Pattern ?

## Visitor Pattern

Visitor Pattern represents an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates. 

### Intent

> Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.

> Do the right thing based on the type of two objects.

> Double dispatch

### Problem

Some languages like Java and C# only support single dispatch, they don't support double dispatch. When you mark a method as virtual, the runtime will choose which method should be called based on the actual type of a __single__ object, therefore it's single dispatch.

See Problem.cs file for an example of single dispatch and how the runtime behaves in double dispatch scenarios.
See Solution.cs for an attempt of solving this problem with a very simple implementation of the Visitor Pattern. This implementation lacks an __ObjectStructure__ (see Participants section)

### Participants

 * __Visitor:__ Declares an operation for each of __ConcreteElement__ in the object structure.
 * __ConcreteVisitor:__ Implements each operation defined by the __Visitor__. Each operation implements a fragment of the algorithm needed for that object.
 * __Element:__ Defines an Accept operation which takes a __Visitor__ as an argument. 
 * __ConcreteElement:__ Implements the Accept operation defined by the __Element__.
 * __ObjectStructure:__ Can enumerate its elements and may provide a high-level interface to allow the __Visitor__ to visit its elements.

### Useful resources

> https://www.exceptionnotfound.net/visitor-the-daily-design-pattern/

> https://manski.net/2013/05/the-visitor-pattern-explained/

> https://lostechies.com/derekgreer/2010/04/19/double-dispatch-is-a-code-smell/