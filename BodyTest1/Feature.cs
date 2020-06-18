using Accord.Statistics.Distributions.Univariate;
using BodyTest1;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

//Visible things like skin and affect are here. Features in general are the lay terms that describe the body. Things that go here
//are for things like symptoms and signs. And things a patient themselves would notice.

namespace BodyTest1
{
    class Feature : Part
    {
        public Skins Skins { set; get; }

        public Feature()
        {
            Skins = new Skins();
        }
       
        public void ReadMessage()
        {
            
            //Console.WriteLine(message);
            
        }
    }

    class Features
    {
        public Neck Neck { set; get; }
        public Features()
        {
            Neck = new Neck();
        }

    }
        


    class Head : Feature
    {
        

    }

    class Neck : Feature
    {
        public Neck()
        {
            InspectionMessage = "Upon visually examining the Neck, you find a rash";
        }
        
    }

    class LeftEar : Feature
    {

    }

    class RightEar : Feature
    {

    }

    class LeftEye : Feature
    {

    }

    class RightEye : Feature
    {

    }

    class Nose : Feature
    {
        LeftNostril leftNostril;
        RightNostril rightNostril;
    }

    class LeftNostril : Feature
    {

    }

    class RightNostril : Feature
    {

    }

    class Mouth : Feature
    {
        UpperLip upperLip;
        LowerLip lowerLip;
    }
    class UpperLip : Feature
    {

    }

    class LowerLip : Feature
    {

    }

    class Philtrum : Feature
    {

    }
    class Jaw : Feature
    {

    }
    class Mandible: Feature
    {

    }
    class Gingivum : Feature
    {

    }
    class Tooth : Feature
    {

    }
    class Tongue : Feature
    {

    }
    class Throat : Feature
    {


    }
    class AdamsApple : Feature
    {

    }

    class VertebralColumn : Feature
    {

    }

    class Arm : Feature
    {

    }

    class Elbow : Feature
    {

    }

    class Wrist : Feature
    {

    }

    class Hand : Feature
    {

    }

    class Finger : Feature
    {

    }
    class Thumb : Feature
    {

    }

    class Nails : Feature
    {

    }

    class Hair : Feature
    {

    }

    class Chest : Feature
    {

    }

    class Breast : Feature
    {

    }

    class Penis : Feature
    {

    }

    class Scrotum : Feature
    {

    }

    class Vulva : Feature
    {

    }

    class Leg : Feature
    {

    }

    class Thigh : Feature
    {

    }

    class Knee : Feature
    {

    }

    class Kneecap : Feature
    {

    }

    class Shin : Feature 
    { 

    }

    class Calf : Feature
    {

    }

    class Ankle : Feature
    {

    }
    
    class Foot : Feature

    { }
    
    class Toe : Feature
    {

    }


}
