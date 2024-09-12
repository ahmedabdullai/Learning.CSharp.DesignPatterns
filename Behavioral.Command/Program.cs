// Create receiver
using Command;

Light livingRoomLight = new Light();

// Create commands
ICommand lightOn = new LightOnCommand(livingRoomLight);
ICommand lightOff = new LightOffCommand(livingRoomLight);

// Create invoker
RemoteControl remote = new RemoteControl();

// Turn the light on
remote.SetCommand(lightOn);
remote.PressButton();

// Turn the light off
remote.SetCommand(lightOff);
remote.PressButton();