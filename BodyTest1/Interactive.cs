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
                ParseInput ParseInput = new ParseInput(body);
                
                if (key == 'i')
                {
                    Console.WriteLine("\n");
                  
                    try
                    {
                        ParseInput.FunctionHash[input = Console.ReadLine()];
                        VisualInspection visualInspection = new VisualInspection(ParseInput.InputHash[input = Console.ReadLine()]);
                        tryAgain = false;
                    }
                    catch { Console.WriteLine("Try a valid bodypart"); }
                }
                else if (key == 's')
                {
                    body.Features.UpdateWounds();
                    foreach (Sign sign in body.Features.FeatureList[0].SignList)
                    {
                        Console.WriteLine(body.Features.FeatureList[0].SignList[0].Name);
                    }
                    tryAgain = false;
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
