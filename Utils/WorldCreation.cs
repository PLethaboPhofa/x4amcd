using x4amcd.Objects;
using x4amcd.Primordials;
using x4amcd.Utils.twodarrays;

namespace x4amcd.Utils
{
    public static class WorldCreation
    {
        public static int WorldWidth
        {
            get;
            set;
        }

        public static int WorldHeight
        {
            get;
            set;
        }

        public static List<List<IThing>> CreateBasicWorld(int rows, int columns)
        {
            WorldHeight = rows;
            WorldWidth = columns;
            return TwoDArrayUtil.MakeTwoDArray(rows, columns, new Rock());
        }
    }
}