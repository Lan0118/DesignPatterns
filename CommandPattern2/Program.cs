using System;

namespace CommandPattern2
{
    /// <summary>
    /// 命令模式
    /// 遥控器-多个按钮和撤销操作
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Living Room Light");
            Light kitchenLight = new Light("Kitchen Light");
            GarageDoor garageDoor = new GarageDoor("GarageDoor");
            Stereo stereo = new Stereo("Stereo");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.setCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.setCommand(2, garageDoorOpen, garageDoorClose);
            remoteControl.setCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl.toString());

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            remoteControl.onButtonWasPushed(1);
            remoteControl.offButtonWasPushed(1);
            remoteControl.onButtonWasPushed(2);
            remoteControl.offButtonWasPushed(2);
            remoteControl.onButtonWasPushed(3);
            remoteControl.offButtonWasPushed(3);


            Console.ReadKey();
        }
    }
}
