using FinchAPI;
using System;

namespace GetItGoing
{
    class Program
    {
        /// <summary>
        /// Get It Going Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // **************************************************
            //
            // Title: Get It Going
            // Description: Get It Going Finch Application
            // Application Type: Console
            // Author: Nate Schlusler
            // Dated Created: 2/14/2018
            // Last Modified:
            //
            // **************************************************

            //
            // declare and instantiate a  Finch object
            //
            Finch myFinch = new Finch();

            //
            // connect to the finch robot using the finch connect method
            //
            myFinch.connect();

            //
            // begin application code here
            //

            // variables
            string userName;
            string noseColor;
            string userResponse;
            int frequency;
            int motorSpeed;
            double duration;
            double speedPercentage;
            double finchTemp;
            double fahrenheit;
            int rightLightSensor;
            int leftLightSensor;
            




            // welcome screen
            Console.Clear();
            Console.WriteLine("Hello user! What is your name?");
            Console.WriteLine();
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello {userName}, welcome to the Get It Going Application.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            // application purpose
            Console.Clear();
            Console.WriteLine("The purpose of this application is find the user input values that will");

            // nose color
            Console.Clear();
            Console.WriteLine("Nose Color");
            Console.WriteLine();
            Console.Write("Enter nose color (red, green, blue):");
            noseColor = Console.ReadLine();

            // frequency
            Console.Clear();
            Console.WriteLine("Frequency");
            Console.WriteLine();
            Console.Write("Enter frequency (hertz):");
            userResponse = Console.ReadLine();
            frequency = int.Parse(userResponse);


            // duration
            Console.Clear();
            Console.WriteLine("Duration");
            Console.WriteLine();
            Console.Write("Enter duration (seconds):");
            userResponse = Console.ReadLine();
            duration = double.Parse(userResponse);

            // speed percentage
            Console.Clear();
            Console.WriteLine("Speed Percentage");
            Console.WriteLine();
            Console.Write("Enter speed (percentage):");
            userResponse = Console.ReadLine();
            speedPercentage = double.Parse(userResponse);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            // echo user choices
            Console.Clear();
            Console.WriteLine("You chose the following selections:");
            Console.WriteLine();
            Console.WriteLine("nose color: " + noseColor);
            Console.WriteLine();
            Console.WriteLine("frequency: " + frequency + " hertz.");
            Console.WriteLine();
            Console.WriteLine("duration: " + duration + " seconds.");
            Console.WriteLine();
            Console.WriteLine("Speed: " + speedPercentage + "%");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            // execute commands
            Console.Clear();
            Console.WriteLine("Execute Commands");
            Console.WriteLine();
            Console.WriteLine("Press any key to execute commands.");
            Console.ReadKey();

            

            // use duration
            int seconds = (int)(duration * 1000);
            myFinch.wait(seconds);

            // set LED nose color
            switch (noseColor)
            {
                case "red":
                    myFinch.setLED(255, 0, 0);
                    break;
                case "green":
                    myFinch.setLED(0, 255, 0);
                    break;
                case "blue":
                    myFinch.setLED(0, 0, 255);
                    break;
                default:
                    break;
            }
            myFinch.wait(seconds);
            myFinch.setLED(0, 0, 0);
            
            
            // set frequency
            myFinch.noteOn(frequency);
            myFinch.wait(seconds);
            myFinch.noteOff();


            // set motor speed
            motorSpeed = (int)((speedPercentage / 100) * 255);
            myFinch.setMotors(motorSpeed, motorSpeed);
            myFinch.wait(seconds);
            myFinch.setMotors(0, 0);

            
            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Press t if you would like to know the temperature. Press s if you would like to know the light sensor values.");
            userResponse = Console.ReadLine().ToLower();
            if (userResponse == "t")
            {
            // get temperature
            finchTemp = myFinch.getTemperature();
            fahrenheit = (myFinch.getTemperature() * 1.8) + 32;
            Console.WriteLine();
            Console.WriteLine($"Current Temperature: {fahrenheit} fahrenheit.");
            }
            
            else if (userResponse == "s")
            {
            // get light sensor value
            leftLightSensor = myFinch.getLeftLightSensor();
            rightLightSensor = myFinch.getRightLightSensor();
            Console.WriteLine();
            Console.WriteLine($"Current Left Light Sensor: {leftLightSensor}");
            Console.WriteLine($"Current Right Light Sensor: {rightLightSensor}");
            Console.WriteLine($"Current Average Light Sensor: {((leftLightSensor) + (rightLightSensor)) / 2}");
            Console.WriteLine();
            }

            
            

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();



            Console.Clear();
            Console.WriteLine("Press r to restart program. Press e to exit.");
            userResponse = Console.ReadLine().ToLower();
            while (userResponse == "r")
            {
                Console.Clear();
                Console.WriteLine("Hello user! What is your name?");
                Console.WriteLine();
                userName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Hello {userName}, welcome to the Get It Going Application.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                // application purpose
                Console.Clear();
                Console.WriteLine("The purpose of this application is find the user input values that will");

                // nose color
                Console.Clear();
                Console.WriteLine("Nose Color");
                Console.WriteLine();
                Console.Write("Enter nose color (red, green, blue):");
                noseColor = Console.ReadLine();

                // frequency
                Console.Clear();
                Console.WriteLine("Frequency");
                Console.WriteLine();
                Console.Write("Enter frequency (hertz):");
                userResponse = Console.ReadLine();
                frequency = int.Parse(userResponse);


                // duration
                Console.Clear();
                Console.WriteLine("Duration");
                Console.WriteLine();
                Console.Write("Enter duration (seconds):");
                userResponse = Console.ReadLine();
                duration = double.Parse(userResponse);

                // speed percentage
                Console.Clear();
                Console.WriteLine("Speed Percentage");
                Console.WriteLine();
                Console.Write("Enter speed (percentage):");
                userResponse = Console.ReadLine();
                speedPercentage = double.Parse(userResponse);
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                // echo user choices
                Console.Clear();
                Console.WriteLine("You chose the following selections:");
                Console.WriteLine();
                Console.WriteLine("nose color: " + noseColor);
                Console.WriteLine();
                Console.WriteLine("frequency: " + frequency + " hertz.");
                Console.WriteLine();
                Console.WriteLine("duration: " + duration + " seconds.");
                Console.WriteLine();
                Console.WriteLine("Speed: " + speedPercentage + "%");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                // execute commands
                Console.Clear();
                Console.WriteLine("Execute Commands");
                Console.WriteLine();
                Console.WriteLine("Press any key to execute commands.");
                Console.ReadKey();



                // use duration
                //int seconds = (int)(duration * 1000);
                myFinch.wait(seconds);

                // set LED nose color
                switch (noseColor)
                {
                    case "red":
                        myFinch.setLED(255, 0, 0);
                        break;
                    case "green":
                        myFinch.setLED(0, 255, 0);
                        break;
                    case "blue":
                        myFinch.setLED(0, 0, 255);
                        break;
                    default:
                        break;
                }
                myFinch.wait(seconds);
                myFinch.setLED(0, 0, 0);


                // set frequency
                myFinch.noteOn(frequency);
                myFinch.wait(seconds);
                myFinch.noteOff();


                // set motor speed
                motorSpeed = (int)((speedPercentage / 100) * 255);
                myFinch.setMotors(motorSpeed, motorSpeed);
                myFinch.wait(seconds);
                myFinch.setMotors(0, 0);



                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Press t if you would like to know the temperature. Press s if you would like to know the light sensor values.");
                userResponse = Console.ReadLine().ToLower();
                if (userResponse == "t")
                {
                    // get temperature
                    finchTemp = myFinch.getTemperature();
                    fahrenheit = (myFinch.getTemperature() * 1.8) + 32;
                    Console.WriteLine();
                    Console.WriteLine($"Current Temperature: {fahrenheit} fahrenheit.");
                }

                else if (userResponse == "s")
                {
                    // get light sensor value
                    leftLightSensor = myFinch.getLeftLightSensor();
                    rightLightSensor = myFinch.getRightLightSensor();
                    Console.WriteLine();
                    Console.WriteLine($"Current Left Light Sensor: {leftLightSensor}");
                    Console.WriteLine($"Current Right Light Sensor: {rightLightSensor}");
                    Console.WriteLine($"Current Average Light Sensor: {((leftLightSensor) + (rightLightSensor)) / 2}");
                    Console.WriteLine();
                }




                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();


            }

            while (userResponse == "e")
            {
                Environment.Exit(0);
            }



            // closing screen

            Console.Clear();
            Console.WriteLine("Thank you for using Get It Going Application.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            //
            // end application code here
            //

            //
            // disconnect from the finch robot using the finch disconnect method
            //
            myFinch.disConnect();
        }
    }
}
