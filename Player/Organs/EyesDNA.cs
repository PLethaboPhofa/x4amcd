using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x4amcd.Primordials;
using x4amcd.World_Scripts;
using x4amcd_Player_Scripts;

namespace x4amcd.Player.Organs
{
    public class EyesDNA
    {
        private readonly int visualAcuity = 5;

        public List<List<IThing>> SeeWorld(AdamDNA adamDNAInstance)
        {
            return World.GetLightMap(World.GetPosition(adamDNAInstance),visualAcuity);
        }

    }
    
}