using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Part
    {
        string name { get; set; }
        string alternateName { get; set; }
        public Symptoms Symptoms { set; get; }
        public Signs Signs { set; get; }
        public string InspectionMessage { set; get; }


        public Part()
        {
            Symptoms = new Symptoms();
            Signs = new Signs();
            InspectionMessage = "The " + name + " has no apparent abnormality.";
        }
    }
}
