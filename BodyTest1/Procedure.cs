using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Procedure
    {
        public Procedure()
        {
            var str = Console.ReadLine();

        }

    }

    class VisualInspection : Procedure
    {
        public VisualInspection(Part part)
        {

            Console.WriteLine(part.InspectionMessage);
            Console.WriteLine("test, part name should be above this");
        }
    }
}
