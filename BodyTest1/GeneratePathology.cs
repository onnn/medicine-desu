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

            var rand = new Random();

            if (rand.Next(0,1) > 0)
            {
                body.Pathologies.PathologyList.Add(new IrritantContactDermatitis(body));
                 
            }
               
            if (body.Record.Age < 25 && NormalDistribution.Random(0.5 ,0.1) < 1.0)
            {
                AcneVulgaris acneVulgaris = new AcneVulgaris(body);
            }

        }
    }
}
