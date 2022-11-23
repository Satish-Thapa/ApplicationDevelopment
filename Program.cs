using AppDev.AbsClass;
using AppDev.InheratingClass;

Class2 myObject = new Class2();

myObject.Area(5);
//myObject.MyName("Ajit"); //private access modifier cannot be used.
//myObject.MyAge(2); // protected cannot be used as well

myObject.MyCountry("Nepal"); //internal access modifier can be used from abstract class.