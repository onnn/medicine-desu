using System;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Skins
    {
        public Epidermis Epidermis { set; get; }
        public Dermis Dermis { set; get; }
        public SubcutaneousTissue  SubcutaneousTissue {set; get;}
        public HairFollicles HairFollicles { set; get; }
        public SebaceousGlands SebaceousGlands { set; get; }
        public Pores Pores { set; get; }
        public Skins()
        {
            Epidermis = new Epidermis();
            Dermis = new Dermis();
            SubcutaneousTissue = new SubcutaneousTissue();
            HairFollicles = new HairFollicles();
            SebaceousGlands = new SebaceousGlands();
            Pores = new Pores();
        }

    }
       

    class Epidermis : Part
    {

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
        public double SebumLevel { set; get; } //severity of sebum. 0 = abscence, 1 = pores overfull

        public Pores()
        {
            SebumLevel = 0.3; 
        }
    }

}

