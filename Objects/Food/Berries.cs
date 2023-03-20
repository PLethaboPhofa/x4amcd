using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using x4amcd.Primordials;
using x4amcd.Utils;

namespace x4amcd.Objects.Food
{
    public class Berries : IThing
    {
        public int Value
        {
            get => 4;
            set { }
        }

        public override String ToString()
        {
            return (" B ")[..PrintHelpers.ThingLength];
        }
    }

}