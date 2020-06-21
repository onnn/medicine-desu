using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Interactive
    {
        /// <summary>
        /// The main menu offers the text based interface. The user types in a command, then a target. For instance, "inspect neck", takes the first
        /// word and uses the VisualInspection() function, then the second word is taken and used as the argument. Other possibilities include 
        /// "conduct MRI" or "ausciltate heart"
        /// </summary>
        /// <param name="body"></param>
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
                        ParseInput ParseInput = new ParseInput(input = Console.ReadLine(), body);
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
