// Create a simple coffee
using DecoratorPattern;

ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

// Add milk to the coffee
coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

// Add sugar to the coffee
coffee = new SugarDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

// Add chocolate to the coffee
coffee = new ChocolateDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");