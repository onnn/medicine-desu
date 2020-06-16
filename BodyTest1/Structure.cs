using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{

    class Bone : Structure
    {
        public double FractureSeverity { set; get; } // 0 = No fracture; between 0 and 0.49. 0.5+ Break; 0.8 Severe Break; 0.9 Shattered; 1.0 Powder
        public string FractureOrientation { set; get; } //transverse, oblique or spiral
        public string FractureAspect { set; get; } //medial, lateral, anterior posterior .on hand and arm: radial, ulnar, dorsal palmar
        public double FractureDisplacement { set; get; } //in percentage. For example, only 25% contact remaining would be 0.75.
        public string FractureRegion { set; get; } //metaphysis, diaphysis, epiphysis
        public double FractureJointSpaceExtention { set; get; } //should be linked to a joint. fractures extending into a joint are more severe and require surgery
        public double FractureAngulation {get; set;} // This is the angle of the fracture.
        public double FractureTissueDamage { get; set; } //Modifies the condition of the overlying tissue. 
        public double FractureSegments { get; set; } //Number of fracture lines
        public double FractureOpen { get; set; } //whether the fracture is open to the environment. Related to tissue damage. Type 1 (puncture). Type 2 (laceration).
        //Type 3A, communited, 3B periosteal stripping, 3C, arterial injury
        public string HealingStage { get; set; } //First stage, inflammtory, second,reparative, third, remodeling, or not healing
        public double StressFractureRisk { get; set; } //Multiplier. Higher risk bones: Pars interarticularis of lumbar spine, femoral head, femoral neck, patella, anterior cortex of tibia (tension side)
        //ankle and foot: medial amlleolus, talus, tarsal navicular, proximal fifth and fourth metatarsals, second metatarsal, great toe sesamoids

       //include common fracture names such as supracondylar fracture

       //TODO: modify condition of overlying tissues (open or closed fracture)
       //Test: radiograph, pain description, physical examination. Advanced: MRI, bonescan CT, ultrasonography

       //ddx: tendinopathy, muscle strain, ligament strain, nerve entrapment strain, shin splint, osteomyletis (infection)
    }

    class Joint : Structure
    {

    }

    class Muscle : Structure
    {

    }

    class Artery : Structure
    {

    }

    class Foraminus : Structure
    {

    }

    class Gland : Structure
    {

    }

    class LymphaticVessel : Structure
    {

    }

    class Nerve : Structure
    {

    }

    class Organ : Structure
    {

    }

    class Vein : Structure
    {

    }
}
