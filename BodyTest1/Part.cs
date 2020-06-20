using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Part
    {
        public string Name { get; set; }
        string AlternateName { get; set; }
        public Symptoms Symptoms { set; get; }
        public Signs Signs { set; get; }
        public string InspectionMessage { set; get; }

        public Part()
        {

            Symptoms = new Symptoms();
            Signs = new Signs();
        }

       
    }
}
