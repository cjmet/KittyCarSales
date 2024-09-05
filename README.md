# KittyCarSales 
## Code:You Software Development Knowledge Check Module 2
- A puppy from Dogtown Motors has broken into Kitty Car Sales and vandalized their computers. We've been tasked with "fixing" the problem.  Put your snippers down, the Catopia County Police Department has already apprehended the suspect.  We need to fix the code, not the puppy.

## Objectives
- The primary objective is the understanding of Debugging, Interfaces, and Extension Methods
- Secondary Stretch Goals include the ability to work with Reflection and Generics

## Required
- **CRITICAL**: Repair the ICar interface so that the the program can compile and run.  All of the cars should have similar properties and methods.  The interface should reflect this.
	- *Hint: Look at the various car classes definitions and determine what is common between them**
		- Answer(s)-ish: The Voltaic is mostly intact, use it to prototype the interface
			- It does have an extra property that is not in the other cars, you can handle that any way you like.
			- There is a bug in the Voltaic.AddFromConsole() method, fix it as well.
			- There are similar, but not identical, bugs in all the car classes.
- There's a bug that keeps displaying all cars even when it shouldn't.  Fix it.
	- *Hint: "This is probaly a bracket or semi-colon issue"*
		- Answer: Program.cs Line 37 ish, the extraneous semi-colon after the if statement is causing the next line to always run. `if (Choice == 2); CLI.GetAllCars(logic);`
- There seems to be multiple display and input bugs.  Fix them.
	- *Hint: "These are probably cut and paste issues"*
		- Answer: (Almost) Every Car child class is missing one of the inputs or the display method is not properly implemented and matching the others.  Inheritance can fix most of these.  However, note that the Voltaic will need a little extra work to handle the extra property.
- Test Each Program Option Carefully and Find and Fix Any More Bugs.
	- *Hint: "Get all cars by make"*
		- Cli.cs around line 82.  The compiler tells you the issue. It's an easy fix. 
		```
		List<ICar> cars = logic.GetAllCarsByMake(make);
		...
		foreach (Car car in cars)
		```		
		- cars is a List of ICar, not Car.  Change the foreach to `foreach (ICar car in cars)`
	- *Hint: "Get Total Inventory Value"*
		- Answer: This one is a simple typo that's just hard to see.  It's in the logic class.
			```
			public Decimal? GetTotalInventoryValue()
			{
				return _cars.Sum(c => c.Price + c.Quantity);
			}
			```
		- The sum is adding the price and quantity together, it should be multiplying them.  Change it to `return _cars.Sum(c => c.Price * c.Quantity);`
	- *Hint: You'll need to implement Cli.GetDecimal()*
- Refactor program.cs to use a switch statement instead of if/else.  
	- *Hint: This might even help readability and simplify or fix other problems.**
		- Answer: This is a good example of why the switch statement was invented.  It's a lot cleaner and easier to read.  See the answer code for an example.
- Repair the Car Class so that Inheritance will work properly.  Make sure all the car classes are properly leveraging inheritance and interfaces.
	- Answer: Similar to above, use the Voltaic to prototype this, just be aware the Voltaic has the extra property.  You can handle this any way you like.
		- While we are in here fixing this there may be an issue with the string format related to the Electric or Not.  See if you can fix that and get all the cars to display in a table nicely. (Option 2 in the menu "Get All Cars")
		- You'll have to lookup format.string, standard string formats, and others.  
		- https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings is one of them.
		- I never found any one short consise table of formats.  Sometimes the documentation is fragmented like this and you just have to keep looking and peicing it together.
		- See the answer code for more details
- Use Inheritance to clean up duplicate code in the Car classes.  
	- *Hint: This might even help or simplify fixing other bugs.*
		- Answer: There were a lot of these. But between inheritance an the interface you can pretty automatically fix them all.  Set the make in each class, and delete everything else in the children and inherit it instead. Write once, use many times, and eleminiate bugs and typos all at the same time.
- Add a new car class that inherits from Car and ICar and has a new property and method
	- Answer: This is entirely up to the student, so there's no one answer here.
- Add one of those cars into the inventory and test all the program methods on it.  
	- *Hint: Either add it to an array of cars or fix inheritance in Cli.AddCar() so the reflection works.*
		- Answer: when all else fails make an array of type of cars
		- ` makes = new List<Type> { typeof(Cattilap), typeof(Cheep), typeof(Duck), ...  };`
		- Just finish out that list and it should be good to go even if reflection fails.
		- If reflection is partially working, but you are missing some cars but not others, make sure all the car children inherit as `NeuvoCar : Car, Icar` 
- Use Extension Methods to add a method to the Car class that will return any car's price as a formatted string  "$76,543.21"
	- I feel like this is straight forward and simple enough to not need to be added to the hints and answers, but instead could be gone over in class as an example if needed.
		- all the code pieces for this are already in the program, just need to be assembled together in the different way.
- Add a menu option to search for a car and display the Price using the Extension Method
	- Again, at this point, this should be very straight forward and simple.  But could be gone over in class as an example if needed.

## Optional
- Use Inheritance to fix the Reflection Issue in CLI.AddCar()
	- *Hint: This will fix itself if you fix inheritance and interfaces*
		- Answer: this really does fix itself once you have inheritance and interfaces working properly.  The reflection will work as expected.  You don't have to understand it at all to fix it, just understand the basic concepts of coding and understanding it's implying that it's doing.
		- This Definately should be gone over in class, or some work done looking up System.Reflection in the documentation and how it works.
- Use Interfaces to fix the ***dynamic*** type issue in CLI.AddCar().  dynamic is bad, we want to remove this and use a proper type.
	- *Hint: This is just changing the type and casting it and/or using the as keyword *
	- Answer: This is a simple fix, just change the type to ICar and cast it as needed.  The compiler will tell you what you need to do.
		- `ICar car = Activator.CreateInstance(type) as ICar;`
- Create a generic that will clone any Car
	- *Hint: the missing pieces of code for this are already in CLI.cs*
		- Answer: Go over this in class, as generic are still pretty new to most students.  
		- Also see the answer code for more details.
- Use the generic to clone a (shallow) copy of a car, change some data (like the year), then add the new modified clone to the inventory.
	- Answer: this is up to each student so theres no one answer.
	- Also Go over this in class as needed.
	

	

