using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    //Todo: implement the organ systems
    class Orgsys : Part
    {
        public MusculoskeletalSystem MusculoskeletalSystem;
        public Orgsys()
        {
            MusculoskeletalSystem = new MusculoskeletalSystem();
        }
    }
}
