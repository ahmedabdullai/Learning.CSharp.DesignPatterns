using IteratorPattern;

var collection = new ConcreteCollection<string>();
collection.AddItem("Item 1");
collection.AddItem("Item 2");
collection.AddItem("Item 3");

IIterator<string> iterator = collection.GetIterator();

while (iterator.MoveNext())
{
    Console.WriteLine(iterator.Current);
}