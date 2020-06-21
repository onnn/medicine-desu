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
        public DateTime DateOfBirth { get; set; }
        public int Age { set; get; }
        public string Address { set; get; }
        public string Sex { set; get; }
        public string Gender { set; get; }
        public string Race { set; get; }
        public double Weight { set; get; }
        public double WeightInLb { set; get; }
        public double HeightInMeters { set; get; }
        public double HeightFeet { set; get; }
        public double HeightInches { set; get; }
        public double Waistline { set; get; }
        public string Insurance { set; get; }
        public string socialSecurityNumber { set; get; }
        public string referredBy { set; get; }
        public string status { set; get; }
        public string maritalStatus { set; get; }
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
        public double BMI { set; get; }



        public Record()
        {
            


            var randombogus = new Bogus.DataSets.Name.Gender();
           
            var randomName = new Bogus.DataSets.Name("en");
            var randomPhone = new Bogus.DataSets.PhoneNumbers("en");
            var randomAddress = new Bogus.DataSets.Address("en");

            Random rand = new Random();
            if (rand.NextDouble() >= 0.5)
            {
                Sex = "female";
                randombogus = (Bogus.DataSets.Name.Gender)1; 
            }
            else
            {
                Sex = "male";
                randombogus = (Bogus.DataSets.Name.Gender)0;

            }

            //generate race
            //source for stats: 2019 US census beaurau estimates
            var racerand = rand.NextDouble();
            if (racerand <= 0.6)
            {
                Race = "white";
            }
            else if (racerand > 0.6 && racerand <= 0.78)
            {
                Race = "hispanic (of any race)";
            }
            else if (racerand > 0.78 && racerand <= 0.91)
            {
                Race = "black";
            }

            else if (racerand > 0.91 && racerand <= 0.97)
            {
                Race = "asian";
            }
            else if (racerand > 0.97 && racerand <= 0.98)
            {
                Race = "native american or alaskan native";
            }
            else if (racerand > 0.98 && racerand <= 0.985)
            {
                Race = "native hawaiian or other pacific islander";
            }
            else
            {
                Race = "two or more races";
            }


            if (Sex == "male")
            {
                //The multiplier makes taller people slightly heavier. Someone 1.9 meters will be about  8% heavier than someone that's 1.5 meters, compared to without the bonus. Make divisor smaller to make effect more extreme
                HeightInMeters = NormalDistribution.Random(1.8, 0.1);
                //if (HeightInMeters < 2.0) { var heightWeightMultiplier = (1 + (HeightInMeters - 2.0) / 4.0); }
                //else { var heightWeightMultiplier = (2.0 + ((HeightInMeters -2.0)  / 4.0)); }
                Weight = NormalDistribution.Random(86, 18); //average values and stddev. source: google
                Waistline = 40 + ((Weight - 86) / 4); //you gain 1in / 4kg
            }
            else
            {
                HeightInMeters = NormalDistribution.Random(1.65, 0.1);
                //if (HeightInMeters < 2.0) { var heightWeightMultiplier = (1 + (HeightInMeters - 2.0) / 4.0); }
                //else { var heightWeightMultiplier = (2.0 + ((HeightInMeters - 2.0) / 4.0)); }

                Weight = NormalDistribution.Random(78, 14);
                Waistline = 36 + ((Weight - 86) / 4); //in meters. since 1kg causes +/- 0.01m waistline. average just happens to be 1.0

            }

            double weightHeightCorrelation = (.5) * ((HeightInMeters * 100) - 180);
            Weight += weightHeightCorrelation;


        //convert meters to ft/in
        var inchFeet = (HeightInMeters / 0.3048);
            HeightFeet = (int)inchFeet;
            HeightInches = Math.Floor(Math.Round((inchFeet - HeightFeet) / 0.0833));

            //convert kg to pounds
            WeightInLb = Weight * 2.20462; 


            FirstName = randomName.FirstName(randombogus);
            LastName = randomName.LastName();
            PhoneNumber = randomPhone.PhoneNumber();
            Address = randomAddress.StreetAddress();

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

            BMI = Weight / Math.Pow(HeightInMeters,2); 
            
        }
    }
}
