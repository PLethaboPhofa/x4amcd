namespace x4amcd.Objects.Player.Organs.Planning.Feed.SubGoals
{
    public class FindFood : IGoal
    {
        public List<IGoal>? SubGoals { get; set; }

        public AdamDNA? Parent { get; set; }

        public FindFood(AdamDNA adam)
        {
            Parent = adam;
            SubGoals = new List<IGoal>();
        }

        public bool IsSuccessful()
        {
            return true;
        }
    }
}