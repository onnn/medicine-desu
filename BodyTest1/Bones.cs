using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BodyTest1
{

    /// <summary>
    /// Each patient has "Bones." It contains the collection of all bones, one for each real bone. Each bone is its own class, and the list is a 
    /// list of objects. The bones are connected by a bi-directional graph to give it structure. Each bone has a variety of realistic properties,
    /// as well as the standard sign+symptoms list. Bones are connected by joints (nodes in the graph).
    /// also todo, include the building blocks of bones, osteocytes, as well as marrow. Divided into the various parts like diphysis. Should be
    /// organized into the categories like sesmoid. It technically has tissue so it may be eventually categorized under that. Then the organization
    /// would be like Part : Tissue : Bone : etc
    /// </summary>
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
