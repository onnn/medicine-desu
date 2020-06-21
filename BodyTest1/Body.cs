using Accord.Math;
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
        }

        /// <summary>
        /// This function accepts no arguments and returns no arguments. 
        /// It writes each sign in the "global sign array"
        /// Every single "part" has its own sign and symptom array. These are then added to the global (per patient) list in a different function.
        /// </summary>
        public void DisplayAllSigns()
        {
            foreach (Sign sign in Signs.SignArray)
            {
                Console.WriteLine(sign.Name);
            }
        }

        /// <summary>
        /// This function accepts nothing and returns nothing.
        /// It displays most of the properties in the Record class. Each patient has one record.
        /// </summary>
        public void PrintPatientData()
        {
            Console.WriteLine(Record.FirstName + " " + Record.LastName);
            Console.WriteLine("Sex: " + Record.Sex);
            Console.WriteLine("Phone Number: " + Record.PhoneNumber);
            Console.WriteLine("Address: " + Record.Address);
            Console.WriteLine("Height: " + Record.HeightInMeters + "m - " + Record.HeightFeet + "ft " + Record.HeightInches + " in" );
            Console.WriteLine("Weight: " + Record.Weight + "kg - " + Record.WeightInLb + "lb");
            Console.WriteLine("Age: " + Record.Age);
            Console.WriteLine("DOB: " + Record.DateOfBirth);
            Console.WriteLine("Waist circumference: " + Record.Waistline);
            Console.WriteLine("Race: " + Record.Race);
            Console.WriteLine("BMI: " + Record.BMI); 
        }
    }

}
