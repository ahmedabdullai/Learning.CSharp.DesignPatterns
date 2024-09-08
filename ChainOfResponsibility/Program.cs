// Create handlers
using ChainOfResponsibility;

JuniorSupport junior = new JuniorSupport();
SeniorSupport senior = new SeniorSupport();
ManagerSupport manager = new ManagerSupport();

// Set up the chain
junior.SetNext(senior);
senior.SetNext(manager);

// Test the chain with different requests
Console.WriteLine("Request: Simple Issue");
junior.HandleRequest("Simple Issue");

Console.WriteLine("\nRequest: Complex Issue");
junior.HandleRequest("Complex Issue");

Console.WriteLine("\nRequest: Very Complex Issue");
junior.HandleRequest("Very Complex Issue");

Console.WriteLine("\nRequest: Unknown Issue");
junior.HandleRequest("Unknown Issue");