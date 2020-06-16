using Accord.Math;
using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Body
    {
        public double BMI { get; set; }
        public Bones Bones { get; set; }
        public Features Features { get; set; }

        public Pathologies Pathologies { get; set; } 
        public Record Record { get; set; }

        public Body()
        {
            Bones = new Bones();
            Features = new Features();
            Pathologies = new Pathologies();
            Record = new Record();
        }
    

        public void WelcomeMessage()
        {
            Console.WriteLine("I'm a patient's body. My BMI is {0}. ", BMI);
        }
    }

}
