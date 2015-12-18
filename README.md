# cs-design-strategies
My notes and work following the C# Design Strategies video.


## Singleton pattern
When you only want one instance of the class ever created.
- Usually just making the class static is just fine. As long as no state is maintained.
- We can also make the ctor private and then make a static method that will call the private ctor.
	- But this doesnt work on multiple threads (which can cause serious problems)
- Great blog post on all of this is here http://csharpindepth.com/Articles/General/Singleton.aspx

##Interfaces 
Something like datetime would be a good dependency with an interface on it so we can test DateTime.Now 
	
##Dependency Injection

##Open-Closed and Liskov
- Open for extension but closed for modification. 
- Liskov Substituion is when multiple things are of one type abstraction and each of the types can be used interchangeably 
