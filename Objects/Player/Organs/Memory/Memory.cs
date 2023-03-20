using x4amcd.Objects.@abstract;
using x4amcd.Primordials;
using x4amcd.Utils;
using x4amcd.Utils.twodarrays;
using x4amcd.World_Scripts;

namespace x4amcd.Objects.Player.Organs.Memory
{
    public sealed class MemoryOrgan
    {
        /// <summary>
        /// No need for a 3d array since we use functions
        /// and object references. This makes life easier.
        /// public List<List<List<IThing>>> MemoryVar { get; } = new();
        /// </summary>
        public List<List<IThing>> Maya { get; } = new();

        public MemoryOrgan()
        {
            Maya = TwoDArrayUtil.MakeTwoDArray(WorldCreation.WorldHeight, WorldCreation.WorldWidth);
        }

        public void Commit(Tuple<int, int> position, int visualAcutity)
        {
            // use mask? yeah makes life easier
            for (int i = 0, iOffest = -visualAcutity; i < (visualAcutity * 2) + 1; i++, iOffest++)
            {
                for (int j = 0, jOffset = -visualAcutity; j < (visualAcutity * 2) + 1; j++, jOffset++)
                {
                    Maya[position.Item1 + iOffest][position.Item2 + jOffset] = World.WorldVar[position.Item1 + iOffest][position.Item2 + jOffset];
                }
            }
        }


    }
}
