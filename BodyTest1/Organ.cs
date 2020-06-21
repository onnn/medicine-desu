using System;
using System.Collections.Generic;
using System.Text;



namespace BodyTest1
{

   /// <summary>
   /// The plan for organ organization [npi] is undecided. Orgsys : Organ? Then circulatory system contains a heart in a list? There seems like there 
   /// would be conflicts with this since for instance, skin is already considered a part of each Feature, rather than as a member of an integumary class. 
   /// Perhaps it could be both.... 
   /// </summary>

    class Organ : Part
    {

    }

    class Skin : Organ
    {
        public Epithelium Epithelium {set; get;}
    }
}
