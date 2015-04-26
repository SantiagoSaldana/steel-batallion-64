// MWO Config File
// version 2.0
// by von Pilsner (thanks to HackNFly!@!!!)
//
// Uses default MWO keybindings and axis as of October 2, 2012
//
// For use with Steel-Batallion-64_v2_beta.zip 
// 64 bit driver code/glue by HackNFly  http://code.google.com/p/steel-batallion-64/
//
// I suggest you add the folowing to user.cfg (remove the //'s)
//
// cl_joystick_gain = 1.35
// cl_joystick_invert_throttle = 0
// cl_joystick_invert_pitch = 1
// cl_joystick_invert_yaw = 0
// cl_joystick_invert_turn = 0
// cl_joystick_throttle_range = 0
// gp_mech_view_look_sensitivity = 0.0090 //Normal view
//
using SBC;
using System;
using System.Collections;
namespace SBC
{
    public class testConfig
    {
        SteelBattalionController controller;
        private Hashtable ButtonKeys = new Hashtable();
        //vJoy joystick;
        bool acquired;
        int ticka = 0;
        int loopa = 0;
        int tickb = 0;
        int loopb = 0;
        int tickc = 0;
        int loopc = 0;
        int jj = 0;
        int pedalmode = 1;

        const int refreshRate = 30; // Number of milliseconds between call to mainLoop

        int speed = 50;
        int speedPrevious = 50; //used to check state change of GearLever
        int peddleDeadZone = 30; //used to avoid peddle input when at rest
        int peddleLoop = 0;//used to stop resting peddle loop

        // This gets called once by main program
        public void Initialize()
        {
            int baseLineIntensity = 3; // Just an average value for LED intensity
            int emergencyLightIntensity = 15; // For stuff like eject,cockpit Hatch,Ignition, and Start

            controller = new SteelBattalionController();
            controller.Init(50); // 50 is refresh rate in milliseconds
            controller.AddButtonKeyMapping(ButtonEnum.Washing,SBC.Key.Z, true);
            //controller.UnInit();


        }

        public void AddButtonKeyMapping(ButtonEnum button, SBC.Key keyCode, bool holdDown)
        {
            if (ButtonKeys.Contains((int)button))
            { int a = 1; }
                //ButtonKeys.Remove((int)button);//to save on later garbage collection
            //ButtonKeys[(int)button] = new KeyProperties(keyCode, holdDown);
        }

        //this is necessary, as main program calls this to know how often to call mainLoop
        public int getRefreshRate()
        {
            return refreshRate;
        }

        //this gets called once every refreshRate milliseconds by main program
        public void mainLoop()
        {
        
        }

        // This gets called at the end of the program and must be present, as it cleans up resources
        public void shutDown()
        {
        
            //controller.UnInit();
            //joystick.Release(1);
        }
    }
}
