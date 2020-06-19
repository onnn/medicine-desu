﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Interactive
    {
        public void MainMenu(Body body)
        {
            bool tryAgain = true;
            while (tryAgain == true)
            {

                Console.WriteLine("Press i to visually inspect the patient");
                Console.WriteLine("Press r to view the patient record");

                var key = Console.ReadKey().KeyChar;
                key = char.ToLower(key);
                string input;
                if (key == 'i')
                {
                    Console.WriteLine("\n");
                    input = Console.ReadLine();


                    Dictionary<string, Part> openWith = new Dictionary<string, Part>();
                    openWith.Add("neck", body.Features.Neck);

                    try
                    {
                        //openWith[input].Name = input;
                        VisualInspection visualInspection = new VisualInspection(openWith[input]);
                        tryAgain = false;
                    }
                    catch { Console.WriteLine("Try a valid bodypart"); }
                }
                else if (key == 's')
                {

                }
                else if (key == 'r')
                {
                    tryAgain = false;
                    body.PrintPatientData();

                }
            }
        }

        public Interactive()
        {

        }
    }
}