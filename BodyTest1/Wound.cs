using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace BodyTest1
{
    class Wound
    {
        public void AddWound(Body body)
        {
            body.Signs.SignArray.Add(this);
            Console.WriteLine("helllllo");
        }
    }

    class Wounds
    {
        public ArrayList WoundArray { set; get; }

        public Wounds()
        {
            WoundArray = new ArrayList();

        }

    }
}
