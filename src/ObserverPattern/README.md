# What is this Pattern ?

## Observer Pattern

This pattern is a mechanism for drastically reduce coupling between interacting classes.

### Intent

> Define a one to many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

> Encapsulate the core or common or engine components in a __Subject__ abstraction and the variable components in an Observer hierarchy.

### Can be applied when:

> The abstraction has tow aspects with one dependent on the other. Encapsulating these aspects in separate objects will increase the chance to reuse them independently.

> The __Subject__ should be able to notify its observer without knowing who these objects are.

### Participants

 * __Subject:__ Knows its observers. Any number of observer objects may observe a subject. Provides an interface to attach and detach __Observer__ objects.
 * __ConcreteSubject:__ Stores state of interest to __ConcreteObserver__. Sends a notification to its observers when the state changes.
 * __Observer:__ Defines an updating interface for objects that should be notified of changes in a __Subject__.
 * __ConcreteObserver:__ Maintains reference to a __ConcreteSubject__. Stores state that should stay consistent with the subjects. Implements the __Observer__ updating interface to keep its state consistent with the subjects.

### Useful resources

> http://www.dotnettricks.com/learn/designpatterns/observer-design-pattern-c-sharp

> http://www.c-sharpcorner.com/uploadfile/40e97e/observer-design-pattern-in-C-Sharp/

> https://sourcemaking.com/design_patterns/observer