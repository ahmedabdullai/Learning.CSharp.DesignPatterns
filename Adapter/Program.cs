using Adapter;

IShape circle = new Circle();
circle.Draw();

// Create a Rectangle object and use an adapter
Rectangle rectangle = new Rectangle();
IShape rectangleAdapter = new RectangleAdapter(rectangle);
rectangleAdapter.Draw();