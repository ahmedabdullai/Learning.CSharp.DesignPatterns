// Create a TV and use a simple remote control
using Bridge;

IDevice tv = new TV();
RemoteControl remoteControl = new RemoteControl(tv);
remoteControl.TurnOn();
remoteControl.SetVolume(10);
remoteControl.TurnOff();

Console.WriteLine();

// Create a Radio and use an advanced remote control
IDevice radio = new Radio();
AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(radio);
advancedRemote.TurnOn();
advancedRemote.SetVolume(5);
advancedRemote.Mute();
advancedRemote.TurnOff();