using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

using x4amcd.Primordials;
using x4amcd.Utils;

namespace x4amcd.Objects
{
    public class Rock : IThing, ICloneable
    {
        private static readonly Random rnd = new();

        private int privateValue = 0;

        public Rock()
        {
        }
        Rock(int privateValue)
        {
            this.privateValue = privateValue;
        }
        public int Value
        {
            get
            {
                if (privateValue == 0)
                {
                    privateValue = rnd.Next(2) + 14;
                }
                return privateValue;
            }
            set { }
        }

        public object Clone()
        {
            return new Rock(this.Value);
        }

        public override String ToString()
        {
            return ("R:" + Value)[..PrintHelpers.ThingLength];
        }
    }
}