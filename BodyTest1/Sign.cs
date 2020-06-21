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
        public string SingularName { get; set; }
        public string PluralName { get; set; }
        public string AlternateName { get; set; }
        public string InspectionMessage { get; set; }

        public Sign()
        {

        }
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
        public Erythema(Body body)
        {
            Name = "erythema";
        }
    }
    class Edema : Sign
    {
        public Edema(Body body)
        {
            Name = "edema";
        }
    }

    class Blister : Sign
    {
        public Blister (Body body)
        {
            Name = "blister";
            SingularName = "a blister";
            PluralName = "blisters"; 
        }
    }
}
