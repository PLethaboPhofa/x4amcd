using x4amcd.Primordials;
using x4amcd.Utils;

namespace x4amcd.Objects.@abstract
{
    public class Known : IThing
    {
        public int Value
        {
            get => 2;
            set { }
        }

        public override String ToString()
        {
            return (" K " + Value)[..PrintHelpers.ThingLength];
        }
    }
}