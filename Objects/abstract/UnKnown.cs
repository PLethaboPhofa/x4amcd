using x4amcd.Primordials;
using x4amcd.Utils;

namespace x4amcd.Objects.@abstract
{
    public class Unknown : IThing
    {
        public int Value
        {
            get => 2;
            set { }
        }

        public override String ToString()
        {
            return (" U " + Value)[..PrintHelpers.ThingLength];
        }
    }
}