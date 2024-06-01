using CommandPattern;
using CommandPattern.Commands;
using CommandPattern.Models;

var bedroomLightReciever = new LightReciever("Bedroom");
var livingRoomLightReciever = new LightReciever("Living Room");

var enableBedroomLightCommand = new EnableLightCommand(bedroomLightReciever);
var enableLivingRoomLightCommand = new EnableLightCommand(livingRoomLightReciever);

var lightCommandInvoker = new LightCommandInvoker(enableLivingRoomLightCommand);

lightCommandInvoker.Enable();

lightCommandInvoker.SetCommand(enableBedroomLightCommand);

lightCommandInvoker.Enable();
lightCommandInvoker.Disable();

lightCommandInvoker.SetCommand(enableLivingRoomLightCommand);

lightCommandInvoker.Disable();