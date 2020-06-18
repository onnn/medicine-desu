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

        public Sign()
        {

        }


        public void AddSign(Body body)
        {
            body.Signs.SignArray.Add(this);
            Console.WriteLine("helllllo");
        }
        
    }

    class Signs
    {
        public ArrayList SignArray { set; get; }

        public Signs()
        {
            Console.WriteLine("SignArray created");
            SignArray = new ArrayList();

        }

    }


    class Erythema : Sign
    {
        public Erythema(Body body)
        {
            Name = "erythema";
            AddSign(body);
        }
    }
    class Edema : Sign
    {
        public Edema(Body body)
        {
            Name = "edema";
        }
    }
}
