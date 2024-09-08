using Flyweight;

CharacterFactory factory = new CharacterFactory();

// Create characters with the same symbol and color but different sizes
ICharacter a1 = factory.GetCharacter('A', "Red");
a1.Display(12);

ICharacter a2 = factory.GetCharacter('A', "Red");
a2.Display(14);

ICharacter b1 = factory.GetCharacter('B', "Blue");
b1.Display(10);

ICharacter b2 = factory.GetCharacter('B', "Blue");
b2.Display(16);

// Verify that the same character object is shared
Console.WriteLine(object.ReferenceEquals(a1, a2)); // True
Console.WriteLine(object.ReferenceEquals(b1, b2)); // True