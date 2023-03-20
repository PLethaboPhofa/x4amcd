using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using x4amcd.Exceptions;
using x4amcd.Objects;
using x4amcd.Primordials;
using x4amcd.Utils;
using x4amcd.Utils.twodarrays;

namespace x4amcd.World_Scripts
{
    public static class World
    {
        public static List<List<IThing>> WorldVar { get; set; } = new();
        public static List<List<IThing>> GetLightMap(Tuple<int, int> position, int visualAcutity)
        {
            List<List<IThing>> lightMap = new();
            for (int i = 0, iOffest = -visualAcutity; i < (visualAcutity * 2) + 1; i++, iOffest++)
            {
                lightMap.Add(new List<IThing>());
                for (int j = 0, jOffset = -visualAcutity; j < (visualAcutity * 2) + 1; j++, jOffset++)
                {
                    lightMap[i].Add(
                        WorldVar[position.Item1 + iOffest][position.Item2 + jOffset]
                    );
                }
            }
            return lightMap;
        }

        public static Tuple<int, int> GetPosition(IThing thing)
        {
            return TwoDArrayUtil.GetPosition(WorldVar, thing);
        }

    }
}