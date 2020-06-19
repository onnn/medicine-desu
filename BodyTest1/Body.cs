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

        public void DisplayAllSigns()
        {
            foreach (Sign sign in Signs.SignArray)
            {
                Console.WriteLine(sign.Name);
            }
        }

        public void PrintPatientData()
        {
            Console.WriteLine(Record.FirstName + " " + Record.LastName);
            Console.WriteLine("Sex: " + Record.Sex);
            Console.WriteLine("Phone Number: " + Record.PhoneNumber);
            Console.WriteLine("Address: " + Record.Address);
            Console.WriteLine("Height: " + Record.Height);
            Console.WriteLine("Weight: " + Record.Weight);
            Console.WriteLine("Age: " + Record.Age);
            Console.WriteLine("DOB: " + Record.DateOfBirth);
            Console.WriteLine("Waist circumference: " + Record.Waistline);
            Console.WriteLine("Race: " + Record.Race);
        }
    }

}
