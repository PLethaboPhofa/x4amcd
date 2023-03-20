using x4amcd.Objects.Player.Organs.Planning.Feed.SubGoals;

namespace x4amcd.Objects.Player.Organs.Planning.Feed
{
    public class Feed : IGoal
    {
        public List<IGoal>? SubGoals { get; set; }

        public AdamDNA? Parent { get; set; }
        public Feed(AdamDNA adam)
        {
            Parent = adam;
            SubGoals = new List<IGoal>
            {
                new FindFood(adam)
            };
        }
    }
}