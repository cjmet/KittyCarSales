# KittyCarSales 
## Code:You Software Development Knowledge Check Module 2
- A puppy from Dogtown Motors has broken into Kitty Car Sales and vandalized their computers. We've been tasked with "fixing" the problem.  Put your snippers down, the Catopia County Police Department has already apprehended the suspect.  We need to fix the code, not the puppy.

## Objectives
- The primary objective is the understanding of Debugging, Interfaces, and Extension Methods
- Secondary Stretch Goals include the ability to work with Reflection and Generics

## Required
- **CRITICAL**: Repair the ICar interface so that the the program can compile and run.  All of the cars should have similar properties and methods.  The interface should reflect this.
	- ~~*Hint: Look at the various car classes definitions and determine what is common between them**~~
- There's a bug that keeps displaying all cars even when it shouldn't.  Fix it.
- There seems to be multiple display and input bugs.  Fix them.
- Test Each Program Option Carefully and Find and Fix Any More Bugs.
	- ~~*Hint: "Get all cars by make"*~~
	- ~~*Hint: "Get Total Inventory Value"*~~
- Refactor program.cs to use a switch statement instead of if/else.  This might even help readability and simplify or fix other problems.
- Repair the Car Class so that Inheritance will work properly.  Make sure all the car classes are properly leveraging inheritance and interfaces.
- Use Inheritance to clean up duplicate code in the Car classes.  This might even help or simplify fixing other bugs.
- Add a new car class that inherits from Car and ICar and has a new property and method
- Add one of those cars into the inventory and test all the program methods on it.
- Use Extension Methods to add a method to the Car class that will return any car's price as a formatted string  "$76,543.21"
- Add a menu option to search for a car and display the Price using the Extension Method
 

## Optional
- Use Inheritance to fix the Reflection Issue in CLI.AddCar()
	- ~~*Hint: This will fix itself if you fix inheritance and interfaces*~~
- Use Interfaces to fix the ***dynamic*** type issue in CLI.AddCar().  dynamic is bad, we want to remove this and use a proper type.
- Create a generic that will clone any Car
- Use the generic to clone a (shallow) copy of a car, change some data (like the year), then add it to the inventory.
	- ~~*Hint: the missing pieces of code for this are already in CLI.cs*~~
	

