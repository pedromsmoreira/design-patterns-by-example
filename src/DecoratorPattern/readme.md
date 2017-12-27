
With the decorator pattern one can add new functionalities to an existing object without altering the structure of the original object. The design pattern creates a wrapper around the original object with the new functionalities.

in the example we decorate a shape by giving it a diferent color without changing the shape object. 

First we create a shape from the shape interface. We will then create an abstract decorator class ShapeDecorator implementing the Shape interface and having Shape object as its instance variable.

RedShapeDecorator is concrete class implementing ShapeDecorator. 

code example by Michiel Vanhaverbeke
