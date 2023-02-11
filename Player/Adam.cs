using x4amcd.Player.Organs;
using x4amcd.Primordials;
using x4amcd.World_Scripts;

namespace x4amcd_Player_Scripts
{

    // TODO: Implement an ADAM builder that instantiates eyes etc separately then builds an adam,
    // currently the DNA anology is not being used to full potiential. 
    public class AdamDNA : IAdamDNA
    {
        private readonly EyesDNA eyes = new();
        private List<List<IThing>> currentLightMap = new(); 
        public void SeeWorld()
        {
            this.currentLightMap = eyes.SeeWorld(this);
        }

        public void RememberWorld()
        {
            throw new NotImplementedException();
        }

        public void AbstractWorld()
        {
            throw new NotImplementedException();
        }

        public void ModelWorld()
        {
            throw new NotImplementedException();
        }

        public void ChooseWorld()
        {
            throw new NotImplementedException();
        }

        public void ActOnWorld()
        {
            throw new NotImplementedException();
        }
    }
}