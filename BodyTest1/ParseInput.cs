﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class ParseInput
    {
        public Dictionary<string, Feature> InputHash { set; get; }
        public Dictionary<string, VisualInspection> FunctionHash {set; get;}

        public ParseInput(string input, Body body)
        {

            InputHash = new Dictionary<string, Feature>()
            {
                {"neck", body.Features.Neck }
            };

            string FirstWord = input.Split(' ').GetValue(0).ToString();
            string SecondWord = input.Split(' ').GetValue(1).ToString();
            Feature SecondWordFeature = InputHash[SecondWord];

            Console.WriteLine(FirstWord + " " + SecondWord); 

            FunctionHash = new Dictionary<string, VisualInspection>()
            {
                {"inspect", new VisualInspection(body.Features.Neck) }
            };

            if (FirstWord == "inspect")
                {
                VisualInspection VisualInspection = new VisualInspection(SecondWordFeature);
                }
        }

        public VisualInspection ParseVisualInspection()
        {

        }
 
    }
}