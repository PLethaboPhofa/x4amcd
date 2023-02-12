using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x4amcd.Objects;
using x4amcd.Primordials;

namespace x4amcd.Utils
{
    public static class WorldCreation
    {
        public static void CreateBasicWorld(List<List<IThing>> world,int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                world.Add(new List<IThing>());
                for (int j = 0; j < columns; j++)
                {
                    world[i].Add(new Rock());
                }
            }
        }
    }
}