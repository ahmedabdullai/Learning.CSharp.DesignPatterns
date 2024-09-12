using AbstractFactoryPattern;

IGuiFactory factory;
string os = "Windows"; // or "Mac"

if (os == "Windows")
{
    factory = new WindowsFactory();
}
else
{
    factory = new MacFactory();
}

Application app = new Application(factory);
app.RenderUI();