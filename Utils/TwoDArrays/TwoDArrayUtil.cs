using x4amcd.Exceptions;
using x4amcd.Objects;
using x4amcd.Objects.@abstract;
using x4amcd.Primordials;

namespace x4amcd.Utils.twodarrays
{
    public static class TwoDArrayUtil
    {
        public static List<List<IThing>> MakeTwoDArray(int rows, int columns, IThing? defaultThing = null)
        {
            List<List<IThing>> twoDArray = new();
            for (int i = 0; i < rows; i++)
            {
                twoDArray.Add(new List<IThing>());
                for (int j = 0; j < columns; j++)
                {
                    twoDArray[i].Add(defaultThing == null ? new Unknown() : new Rock());
                }
            }
            return twoDArray;
        }

        public static Tuple<int, int> GetPosition(List<List<IThing>> twoDArray, IThing thing)
        {
            int column = -1;
            int row = twoDArray.FindIndex((row) =>
            {
                column = row.IndexOf(thing);
                return column != -1;
            });
            return column == -1 ?
                throw new EThingNotFound() :
                new Tuple<int, int>(row, column);
        }
    }
}