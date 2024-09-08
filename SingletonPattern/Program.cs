using SingletonPattern;

Console.WriteLine("Logger Class");
Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

Console.WriteLine(logger1.GetHashCode());
Console.WriteLine(logger2.GetHashCode());


Console.WriteLine("Settings Class");
Settings settings1 = Settings.GetInstance();
Settings settings2 = Settings.GetInstance();


settings1.SetConfig("key1", "value1");
settings1.PrintConfigs();

settings2.SetConfig("key2", "value2");
settings2.PrintConfigs();