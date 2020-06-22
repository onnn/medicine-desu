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
        public List<Symptom> SymptomList { set; get; } //TODO make into a list<Symptoms>
        public List<Sign> SignList { set; get; }
        public string InspectionMessage { set; get; }

        public Part()
        {
            SymptomList = new List<Symptom>();
            SignList = new List<Sign>();

        }

       
    }

    class Parts
    {
        public Parts()
        {
            
        }
    }
}
