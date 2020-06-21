using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Skins
    {
        public Epidermis Epidermis { set; get; }
        public Dermis Dermis { set; get; }
        public HairFollicles HairFollicles { set; get; }
        public SebaceousGlands SebaceousGlands { set; get; }
        public Pores Pores { set; get; }
        public Skins()
        {
            Epidermis = new Epidermis();
        }

    }
       

    class Epidermis : Part
    {
        public Epidermis()
        {
           
        }
    }

    class Dermis : Part
    {

    }

    class SubcutaneousTissue : Tissue
    {

    }

    class HairFollicles : Part
    {

    }

    class SebaceousGlands : Gland

    {

    }

    class Pores : Part
    {
        //TODO: low sebum causes slightly higher infection chance
        //decreases skin dryness
        //increases body odor
        //link with Proprionibacterium acnes presence
        public double SebumLevel { set; get; } //severity of sebum. 0 = abscence, 1 = pores overfull

        public Pores()
        {
            SebumLevel = 0.3; 
        }
    }

}

