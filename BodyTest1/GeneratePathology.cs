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

            if (NormalDistribution.Random(0.5,0.1) < 1.0)
            {
                IrritantContactDermatitis irritantContactDermatitis = new IrritantContactDermatitis(body);
            }
               
            if (body.Record.Age < 25 && NormalDistribution.Random(0.5 ,0.1) < 1.0)
            {
                AcneVulgaris acneVulgaris = new AcneVulgaris(body);
            }

        }
    }
}
