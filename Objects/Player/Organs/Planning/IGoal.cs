namespace x4amcd.Objects.Player.Organs.Planning
{
    public interface IGoal
    {
        public List<IGoal>? SubGoals { get; set; }


        public bool IsSuccessful()
        {
            foreach (IGoal subGoal in SubGoals!)
            {
                if (!subGoal.IsSuccessful())
                {
                    return false;
                }
            }
            return true;
        }
    }
}