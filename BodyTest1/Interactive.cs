using System;
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
                body = new Body();
                Console.WriteLine("Press i to visually inspect the patient");
                Console.WriteLine("Press r to view the patient record");
                var key = Console.ReadKey().KeyChar;
                key = char.ToLower(key);
                string input; 
                
                if (key == 'i')
                {
                    Console.WriteLine("\n");
                   




                    try
                    {

                        VisualInspection visualInspection = new VisualInspection(body.Features.InputHash[input = Console.ReadLine()]);
                        tryAgain = false;
                    }
                    catch { Console.WriteLine("Try a valid bodypart"); }
                }
                else if (key == 's')
                {
                    foreach (Sign sign in body.Features.Neck.Signs.SignArray)
                    {
                        Console.WriteLine(sign.ToString()); 
                    }
                }
                else if (key == 'r')
                {
                    body.PrintPatientData();

                }
                else if (key == 'q')
                {
                    tryAgain = false;
                }
            }
        }

        public Interactive()
        {

        }
    }
}
