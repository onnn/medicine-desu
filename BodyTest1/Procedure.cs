using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Procedure
    {
        public Procedure()
        {

        }

    }

    class VisualInspection : Procedure
    {
        public VisualInspection(Feature feature)
        {
            Console.WriteLine(feature.InspectionMessage);

        }
    }
}
