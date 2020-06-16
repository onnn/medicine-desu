using Accord.Statistics.Distributions.Univariate;
using System;

namespace BodyTest1
{
    class Pathologies
    {
        public double irritantContactDermatitisProbability { set; get; }

        public Pathologies()
        {

        }
    }
    class VertebralFracture : Pathology
    { 

        public VertebralFracture(Body body)
        {
            ICD10 = "a";

            if (Probability >= 0.3)
            {
                BrokenBone brokenBone = new BrokenBone();
                
                brokenBone.probabilty = 1.0; 
            }
            
        }

        void traumaFracture()
        {
           
        }

        public void stressFracture(Body body)
        {

        }
    }

    class IrritantContactDermatitis : Pathology
    {
         
        public IrritantContactDermatitis(Body body)
        {
            var rand = NormalDistribution.Random(0.5, 0.1);
            Console.WriteLine(rand);
            if (Probability >= 0.0)
            {
                body.Features.Neck.symptom = new Rash();

            }
            if (rand >= 0.5)
            {
                body.Features.Neck.symptom = new Itching();
            }
        }
    }
}
