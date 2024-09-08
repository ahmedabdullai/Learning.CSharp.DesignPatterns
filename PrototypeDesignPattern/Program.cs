// Create an original object
using PrototypeDesignPattern;

Person originalPerson = new Person("Alice", 30);
Console.WriteLine("Original Person: " + originalPerson);

// Clone the original object
Person clonedPerson = originalPerson.Clone();
Console.WriteLine("Cloned Person: " + clonedPerson);

// Modify the cloned object
clonedPerson.Name = "Bob";
clonedPerson.Age = 25;

Console.WriteLine("\nAfter modifying the cloned object:");
Console.WriteLine("Original Person: " + originalPerson);
Console.WriteLine("Cloned Person: " + clonedPerson);