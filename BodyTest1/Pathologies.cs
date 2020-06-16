using Accord.Statistics.Distributions.Univariate;
using Bogus.DataSets;
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
            Name = "Irritant Contact Dermatitis";
            AlternateName = "ICD";
            ICD10 = "L24";
            var rand = NormalDistribution.Random(0.5, 0.1);
            Console.WriteLine(rand);
            if (Probability >= 0.0)
            {
                body.Features.Neck.Symptoms.SymptomArray.Add(new Rash());
                body.Features.Neck.Signs.SignArray.Add(new Erythema());

            }
            if (rand >= 0.5)
            {
                body.Features.Neck.Symptoms.SymptomArray.Add(new Itching());
            }
        }
    }
}
