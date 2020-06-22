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
    /// 
    /// todo: add bone variation. This may eventually control height
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
    class CervicalVertebrae2 : Bone
    {

    }
    class CervicalVertebrae3 : Bone
    {

    }
    class CervicalVertebrae4 : Bone
    {

    }
    class CervicalVertebrae5 : Bone
    {

    }
    class CervicalVertebrae6 : Bone
    {

    }
    class ThoracicVertebrae1 : Bone
    {

    }

    class ThoracicVertebrae2 : Bone
    {

    }

    class ThoracicVertebrae3 : Bone
    {

    }
    class ThoracicVertebrae4 : Bone
    {

    }
    class ThoracicVertebrae5 : Bone
    {

    }
    class ThoracicVertebrae6 : Bone
    {

    }
    class ThoracicVertebrae7 : Bone
    {

    }
    class ThoracicVertebrae8 : Bone
    {

    }
    class ThoracicVertebrae9 : Bone
    {

    }
    class ThoracicVertebrae10 : Bone
    {

    }
    class ThoracicVertebrae11 : Bone
    {

    }
    class ThoracicVertebrae12 : Bone
    {

    }
    
    class LumbarVertebrae1 : Bone
    {

    }

    class LumbarVertebrae2 : Bone
    {

    }

    class LumbarVertebrae3 : Bone
    {

    }

    class LumbarVertebrae4 : Bone
    { 

    }

    class LumbarVertebrae5 : Bone
    {

    }

    class Sacrum : Bone
    {

    }

    class CoccygealVertebrae : Bone
    {

    }
    class HyoidBone : Bone
    {

    }
    class Sternum : Bone
    {

    }
    class Rib1Right : Bone
    {

    }
    class Rib1Left : Bone
    {

    }
    class Rib2Right : Bone
    {

    }
    class Rib2Left : Bone
    {

    }
    class Rib3Right : Bone
    {

    }
    class Rib3Left : Bone
    {

    }
    class Rib4Left : Bone
    {

    }
    class Rib4Right : Bone
    {

    }

    class Rib5Left : Bone
    {

    }
    class Rib5Right : Bone
    {

    }
    class Rib6Left : Bone
    {

    }
    class Rib6Right : Bone
    {

    }
    class Rib7Left : Bone
    {

    }
    class Rib7Right : Bone
    {

    }
    class Rib8Left : Bone
    {

    }
    class Rib8Right : Bone
    {

    }
    class Rib9Left : Bone
    {

    }
    class Rib9Right : Bone
    {

    }
    class Rib10Left : Bone
    {

    }
    class Rib10Right : Bone
    {

    }
    class Rib11Left : Bone
    {

    }
    class Rib11Right : Bone
    {

    }
    class Rib12Left : Bone
    {

    }
    class Rib12Right : Bone
    {

    }

}
