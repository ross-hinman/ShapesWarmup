# ShapesWarmup

## This is a warmup for the test.  Do not fret if you do not complete it in the time allotted.  I have added several tasks into this to provide extra challenges for those who finish early.  If you only do part of the Rectangle class, that's OK.  This is meant to get your fingers and brains moving, nothing more.

* Implement the Rectangle class.
    * Create Properties for Length and Width to store the length and width values from the constructor
    * Implement CalculateArea
    * Override the ToString method so that it returns the string "This *shape name* has area *area*".  *shape name* = the name of the shape, *area* should be the result of the calculate area method, formatted to 2 decimal places.
* Create an interface IColor
    * IColor should have 1 method: string GetColor();
* Create Square class that inherits from Rectangle
    * Pass "Square" as the name of the shape.
    * Implement the IColor Interface
    * Be able to set the color of the Square through the constructor, and return the color through the GetColor method
    * Make the ToString method of Square also include the color of the Square.
* Create a Triangle class that inherits from Shape
    * Area - Google Heron's Formula
    * Create an appropriate ToString method for Triangle
    * Also make it implement the IColor interface.
