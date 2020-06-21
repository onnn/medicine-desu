using Accord.Statistics.Distributions.Univariate;
using Bogus.DataSets;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BodyTest1
{
    class Pathologies
    {
        public List<Pathology> PathologyList;
        public Pathologies()
        {
            PathologyList = new List<Pathology>();
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
            //HashSet<string> Subtype = new HashSet<string>();

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


            var rand = new Random();
            var location = rand.Next(0, 1);
            Feature affectedFeature;

                affectedFeature = location switch
                {
                    0 => body.Features.Neck,
                    _ => body.Features.Neck,
                };

            affectedFeature.Skins.Epidermis.SignList.Add(new Erythema(body));
            this.Subtype = "acute";
              
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
