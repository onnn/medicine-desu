using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class GeneratePathology
    {
        public GeneratePathology(Body body)
        {

            if (NormalDistribution.Random(0.5,0.1) < 1.0)
            {
                IrritantContactDermatitis irritantContactDermatitis = new IrritantContactDermatitis(body);
            }
               
            if (body.Record.Age < 29 && NormalDistribution.Random(0.5 ,0.1) < 1.0)
            {
                body.Features.Neck.Symptoms.SymptomArray.Add(new AcneVulgaris(body));
                
            }
 

        }
    }
}
