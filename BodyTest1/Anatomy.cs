using System;
using Accord;
using Accord.Statistics.Distributions.Univariate;
using System.Threading;
using QuickGraph;

namespace BodyTest1
{
    class Anatomy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            Body body = new Body();
            GeneratePathology generatePathology = new GeneratePathology(body);

            Console.WriteLine(body.Record.Age);

            var key = Console.ReadKey().KeyChar;
            key = Char.ToLower(key); 
            if (key == 'i')
            {
                Console.WriteLine("\n"); 
                VisualInspection visualInspection = new VisualInspection(body.Features.Neck);
            }

            body.WelcomeMessage();
        }


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

