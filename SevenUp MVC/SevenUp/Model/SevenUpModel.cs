using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SevenUp.Model
{
    public class SevenUpModel
    {
        public int Box1 { get; set; }
        public int Box2 { get; set; }
        public int Box3 { get; set; }
        public int Box4 { get; set; }
        public int Box5 { get; set; }
        public int Box6 { get; set; }
        public int Box7 { get; set; }
        //public string Seven { get; set; }
        //public string Up { get; set; }
        //public string SevenUp { get; set; }

        public string Translate(int boxValue)
        {
            if (boxValue % 7 == 0 && (boxValue % 12 == 0))
            {
                return "Seven Up";

            }
            if (boxValue % 7 == 0)
            {
                return "Seven";
            }
            if (boxValue % 12 == 0)
            {
                return "Up";
            }

            return boxValue.ToString();
        }

    }

}