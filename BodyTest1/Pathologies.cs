using Accord.Statistics.Distributions.Univariate;
using Bogus.DataSets;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BodyTest1
{
    class Pathologies
    {
        public ArrayList PathologyArray { set; get; }
        public Pathologies()
        {

        }
    }
    class VertebralFracture : Pathology
    { 


    }

    class IrritantContactDermatitis : Pathology
    {
        
        public string Subtype { set; get; }

        public IrritantContactDermatitis(Body body)
        {
            Name = "Irritant Contact Dermatitis";
            AlternateName = "ICD";
            ICD10 = "L24";
            HashSet<string> Subtype = new HashSet<string>();

            /*Subtype.Add("acute");
            Subtype.Add("acute delayed");
            Subtype.Add("Irritant reaction");
            Subtype.Add("cumulative");
            Subtype.Add("asteatotic");
            Subtype.Add("traumatic");
            Subtype.Add("subjective");
            Subtype.Add("airborne");
            Subtype.Add("Frictional");*/

            //The types. Not sure yet how to implement them. 


            var rand = NormalDistribution.Random(0.5, 0.1);
            Console.WriteLine(rand);
            if (Probability >= 0.0)
            {
                Console.WriteLine("hello"); 
                
                body.Features.Neck.Symptoms.SymptomArray.Add(new Rash());
                body.Features.Neck.Signs.SignArray.Add(new Erythema(body));
                body.Features.Neck.Skins.Epidermis.Add(new Blister(body));
                
            }
            if (rand >= 0.5)
            {
                body.Features.Neck.Symptoms.SymptomArray.Add(new Itching());
                body.Features.Neck.Signs.SignArray.Add(new Edema(body));
            }
        }


      


    }

    class AcneVulgaris : Pathology

    {
        public double AcneSpread { set; get; }
        public AcneVulgaris(Body body)
        {
            Name = "acne vulgaris";
            AlternateName = "acne";

        }
    }
    }
