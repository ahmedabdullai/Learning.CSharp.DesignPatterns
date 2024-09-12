using FacadePattern;

var amplifier = new Amplifier();
var cdPlayer = new CDPlayer();
var projector = new Projector();
var screen = new Screen();
var lights = new Lights();

var homeTheater = new HomeTheaterFacade(amplifier, cdPlayer, projector, screen, lights);

homeTheater.WatchMovie("Inception");
Console.WriteLine();
homeTheater.EndMovie();