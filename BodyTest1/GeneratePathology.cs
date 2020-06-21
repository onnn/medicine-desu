using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{

    /// <summary>
    /// This class creates the pathology for the patient. The current logic is that a pathology is randomly chosen, then the patient gets 
    /// attributes (in the form of objects) that the illness may really give them. 
    /// Ultimately, the patient's record should generate the illness based on their risks, demographics, etc. Although, that will
    /// have to be random too, so otherwise healthy people may get sick for no reason.
    /// Eventually this class should have all the statistical risks etc, like older women being the main osteoporosis patients, or people under 25
    /// having acne (something like 40% of all have it), so for example, an under 25 generated person would have a %40 chance of having it no matter what.
    /// </summary>
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
