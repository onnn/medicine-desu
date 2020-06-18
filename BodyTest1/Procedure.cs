using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Procedure
    {

    }

    class VisualInspection : Procedure
    {
        public VisualInspection(Part part)
        {
            Console.WriteLine(part.InspectionMessage);
            
        }
    }
}
