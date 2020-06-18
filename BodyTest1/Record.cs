using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Record
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string PhoneNumber { set; get; }
        public DateTime DateOfBirth {get; set; }
        public int Age { set; get; }
        public string Address { set; get; }
        public string Sex { set; get; }
        public string Gender { set; get; }
        public double Weight { set; get; }
        public double Height { set; get; }
        public string Insurance { set; get; }
        public string socialSecurityNumber { set; get; }
        public string referredBy { set; get; }
        public string status { set; get; }
        public string maritalStatus { set; get; }
        public string Race { set; get; }
        public string Language { set; get; }
        public string medicalRecordNumber { set; get; }
        public string employmentStatus { set; get; }
        public string Problems { set; get; }
        public string Medications { set; get; }
        public string Directives { set; get; }
        public string Provider { set; get; }
        public string servicesDue { set; get; }
        public string historyOf { set; get; }
        public string reasonForVisit { set; get; }
        public string chiefComplaint { set; get; }
        public double BMI { set; get;  }

        public Record()
        {
            var randombogus = new Bogus.DataSets.Name.Gender();
            var randomName = new Bogus.DataSets.Name("en");
            var randomPhone = new Bogus.DataSets.PhoneNumbers("en");
            Random rand = new Random();
            if (NormalDistribution.Random(0.5,0) > 0.5)
            {
                Sex = "female";
            }
            else
            {
                Sex = "male";
            }

            if(Sex == "male")
            {
                Weight = NormalDistribution.Random(190, 20);
            }
            else
            {
                Weight = NormalDistribution.Random(190, 20);
            }


            FirstName = randomName.FirstName(randombogus);
            LastName = randomName.LastName();
            PhoneNumber = randomPhone.PhoneNumber();

            Random gen = new Random();
            double probability = gen.NextDouble();
            DateTime start = new DateTime(DateTime.Today.Year - 85, 1, 1);

            int rangeMax; int rangeMin;
            if (probability <= 0.15)
            {
                rangeMin = 0; rangeMax = (85*365 - 65*365);
            }
            else
            {
                rangeMin = 21 * 365;  rangeMax = 65 * 365;
            }

            DateOfBirth = start.AddDays(gen.Next(rangeMin,rangeMax));
            Age = DateTime.Today.Year - DateOfBirth.Year;
            if (DateOfBirth.Date > DateTime.Today.AddYears(-Age)) Age--;
            Console.WriteLine(DateOfBirth);
            Console.WriteLine(probability);

            BMI = Weight / Math.Pow(Height,2); 
            
        }
    }
}
