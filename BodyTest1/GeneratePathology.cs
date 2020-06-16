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
                Console.WriteLine("Testing"); 
                IrritantContactDermatitis irritantContactDermatitis = new IrritantContactDermatitis(body);
            }

        }
    }
}
