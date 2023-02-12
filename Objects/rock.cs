using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x4amcd.Primordials;
using x4amcd.Utils;

namespace x4amcd.Objects
{
    public class Rock : IThing
    {
        private static readonly Random rnd = new();

        private int privateValue = 0;
        public int Value
        {
            get
            {
                if(privateValue == 0){
                    privateValue = rnd.Next(8)+1;
                }
                return privateValue;
            }
            set{}
        }

        public override String ToString()
        {
            return ("R:" + Value)[..PrintHelpers.ThingLength];
        }
    }
}