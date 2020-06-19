using System;
using Accord;
using Accord.Statistics.Distributions.Univariate;
using System.Threading;
using QuickGraph;
using System.Collections.Generic;

namespace BodyTest1
{
    class Anatomy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the medical patient simulator.\n");
            Body body = new Body();
            GeneratePathology generatePathology = new GeneratePathology(body);

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

                openWith[input].Name = input;
                VisualInspection visualInspection = new VisualInspection(openWith[input]);
                Console.WriteLine(body.Features.Neck.Name);
            }
            else if (key == 's')
            {
                
            }
            else if (key == 'r')
            {
                body.PrintPatientData();
            }
            
        }


    }

    class Parts
    {

    }

    class System : Part
    {

    }

    class Region : Part
    {

    }

    class Structure : Part
    {

    }

    class Variation
    {

    }

    class Pathology
    {
        public string ICD10 { set; get; }
        public double Probability { set; get; }
        public string Name { set; get; }
        public string AlternateName { set; get; }
        public Pathology()
        {
            Probability = 0.3;
        }
    }

    class Symptom
    {
        public double probabilty { set; get; }

        public Symptom()
        {
            probabilty = 0; 
        }
    }



}

