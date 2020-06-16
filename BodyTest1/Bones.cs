using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BodyTest1
{


    class Bones
    {
        
        public CervicalVertebrae1 cervicalVertebrae1 = new CervicalVertebrae1();
        public double healingRate { set; get; }
        public double boneMineralDensityTScore { set; get; } //T-score, standard deviations above/below average. -1--2.5 below normal indicates osteopenia. -2.5 indicates osteoporosis
        double boneMineralDensityZScore {set; get; } //Number of standard deviations for your age. Indicates something other than aging causing bone loss
}

    class CervicalVertebrae1 : Bone
    {
        
    }
}
