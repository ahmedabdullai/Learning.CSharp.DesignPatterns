using ObserverPattern;

WeatherStation weatherStation = new WeatherStation();

PhoneDisplay phoneDisplay = new PhoneDisplay("Phone");
WindowDisplay windowDisplay = new WindowDisplay("Window");

weatherStation.Attach(phoneDisplay);
weatherStation.Attach(windowDisplay);

weatherStation.Temperature = 25.0f;
weatherStation.Temperature = 28.5f;

weatherStation.Detach(phoneDisplay);

weatherStation.Temperature = 30.0f;