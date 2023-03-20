using x4amcd.Objects.Player.Organs.Memory;
using x4amcd.Objects.Player.Organs.Planning;
using x4amcd.Objects.Player.Organs.Planning.Feed;
using x4amcd.Player.Organs;
using x4amcd.Primordials;
using x4amcd.Utils;
using x4amcd.World_Scripts;

using x4amcd_Player_Scripts;

namespace x4amcd.Objects.Player
{
    // TODO: Implement an ADAM builder that instantiates eyes etc separately then builds an adam,
    // currently the DNA anology is not being used to full potiential. 
    public class AdamDNA : IAdamDNA
    {
        private readonly EyesDNA eyes = new();
        private readonly MemoryOrgan Memory = new();

        private readonly List<IGoal> Goals = new();
        public int Value
        {
            get => 0;
            set { }
        }

        public List<List<IThing>> CurrentLightMap { get; set; } = new();
        public void SeeWorld()
        {
            CurrentLightMap = eyes.SeeWorld(this);
        }

        public void RememberWorld()
        {
            Memory.Commit(World.GetPosition(this), eyes.VisualAcuity);
        }

        public List<List<IThing>> GetMask()
        {
            return Memory.Maya;
        }

        public void AbstractWorld()
        {
            Goals.Add(new Feed(this));
        }

        public void ModelWorld()
        {
            foreach (var goal in Goals)
            {
                goal.SubGoals?.ForEach(subGoal => subGoal.IsSuccessful());
            }
        }

        public void ChooseWorld()
        {
            throw new NotImplementedException();
        }

        public void ActOnWorld()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return (" A " + Value)[..PrintHelpers.ThingLength];
        }
    }
}