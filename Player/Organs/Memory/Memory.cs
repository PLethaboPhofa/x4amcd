using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x4amcd.Primordials;

namespace x4amcd.Player.Organs
{
    public class MemoryOrgan
    {
        public List<List<List<IThing>>> MemoryVar { get; } = new();

        internal void Commit(List<List<IThing>> currentLightMap)
        {
            MemoryVar.Add(currentLightMap);
        }
    }
}