using Bogus.DataSets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Sign
    {
        public string Name { get; set; }
        public string AlternateName { get; set; }
        public string InspectionMessage { get; set; }
        
    }

    class Signs
    {
        public ArrayList SignArray { set; get; }

        public Signs()
        {
            SignArray = new ArrayList();
        }

    }


    class Erythema : Sign
    {
        public Erythema()
        {
            Name = "erythema";
            InspectionMessage = "Upon examination, you discover erythema.";
        }
        
    }
}
