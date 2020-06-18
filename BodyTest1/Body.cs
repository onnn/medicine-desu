﻿using Accord.Math;
using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections;
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
        public Signs Signs { get; set; }
        public Body()
        {

            Bones = new Bones();
            Features = new Features();
            Pathologies = new Pathologies();
            Signs = new Signs();
            Record = new Record();
            //SymptomArray = new ArrayList();
        }
    

        public void WelcomeMessage()
        {
            Console.WriteLine("I'm a patient's body. My BMI is {0}. ", BMI);
        }

        public void DisplayAllSymptoms()
        {
            foreach (Sign sign in this.Signs.SignArray)
            {
                Console.WriteLine("Writing all Signs"); 
                Console.WriteLine(sign.Name);
            }
        }
    }

}
