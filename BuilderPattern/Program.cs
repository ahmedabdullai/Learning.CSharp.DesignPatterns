//using BuilderPattern;

//Console.WriteLine("Conf 1");
//Configuration configuration = new();
//configuration.SetMotherboard("ASUS ROG Strix Z390-E Gaming")
//             .SetCpu("Intel Core i9-9900K")
//             .SetRam("Corsair Vengeance LPX 32GB")
//             .SetStorage("Samsung 970 EVO Plus 1TB");


//configuration.PrintConfiguration();





//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("Conf 2");
//Configuration2 configuration2 = new Configuration2.Builder()
//    .SetMotherboard("ASUS ROG Strix Z390-E Gaming")
//    .SetCPU("Intel Core i9-9900K")
//    .SetRAM("Corsair Vengeance LPX 32GB")
//    .SetStorage("Samsung 970 EVO Plus 1TB")
//    .SetPowerSupply("EVGA SuperNOVA 850 G5")
//    .SetCase("NZXT H510")
//    .SetMonitor("ASUS VG248QE")
//    .SetKeyboard("Corsair K95 RGB Platinum")
//    .SetMouse("Logitech G502 HERO")
//    .Build();

//configuration2.PrintConfiguration();








//// The client code creates a builder object, passes it to the
//// director and then initiates the construction process. The end
//// result is retrieved from the builder object.
//using BuilderPattern.RefactoringGuru;

//var director = new Director();
//var builder = new ConcreteBuilder();
//director.Builder = builder;

//Console.WriteLine("Standard basic product:");
//director.BuildMinimalViableProduct();
//Console.WriteLine(builder.GetProduct().ListParts());

//Console.WriteLine("Standard full featured product:");
//director.BuildFullFeaturedProduct();
//Console.WriteLine(builder.GetProduct().ListParts());

//// Remember, the Builder pattern can be used without a Director
//// class.
//Console.WriteLine("Custom product:");
//builder.BuildPartA();
//builder.BuildPartC();
//Console.Write(builder.GetProduct().ListParts());














//// Using the Builder to create a Car object
//using BuilderPattern.ChatGPT;
//using BuilderPattern.MySample;

//Car car = new Car.Builder()
//    .SetMake("Toyota")
//    .SetModel("Camry")
//    .SetYear(2024)
//    .SetColor("Red")
//    .SetEngine("V6")
//    .Build();

//Console.WriteLine($"Car Details: {car.Make} {car.Model} ({car.Year}), {car.Color} with {car.Engine} engine.");





//Recepie recepie = new Recepie.Builder().AddIngredient("Flour")
//                                .AddIngredient("Sugar")
//                                .AddIngredient("Eggs")
//                                .AddIngredient("Milk")
//                                .Build();
//recepie.PrintRecepie();



using BuilderPattern.MySample;

Trip trip = new Trip.Builder()
    .SetHotel("Marriot")
    .SetFlight("Delta")
    .SetCar("Audi")
    .Build();

Console.WriteLine(trip.ToString());