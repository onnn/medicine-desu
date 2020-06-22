using System;
using Accord;
using Accord.Statistics.Distributions.Univariate;
using System.Threading;
using QuickGraph;
using System.Collections.Generic;

namespace BodyTest1
{
    class Simulation
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the medical patient simulator.\n");
            Body body = new Body();
            GeneratePathology generatePathology = new GeneratePathology(body);
            Interactive Interactive = new Interactive();

            Interactive.MainMenu(body);
        }


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
        public double Probabilty { set; get; }

        public Symptom()
        {
            //probabilty = 0; 
        }
    }



}

