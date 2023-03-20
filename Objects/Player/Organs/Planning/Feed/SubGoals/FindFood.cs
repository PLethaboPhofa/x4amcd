using x4amcd.Objects.Food;

namespace x4amcd.Objects.Player.Organs.Planning.Feed.SubGoals
{
    public class FindFood : IGoal
    {
        public List<IGoal>? SubGoals { get; set; }

        public AdamDNA? Parent { get; set; }

        public Tuple<int, int>? FoodItemPosition { get; set; }

        public FindFood(AdamDNA adam)
        {
            Parent = adam;
            SubGoals = new List<IGoal>();
        }

        public bool IsSuccessful()
        {
            int column = -1;
            int row = Parent!.GetMask().FindIndex((row) =>
            {
                for (int i = 0; i < row.Count; i++)
                {
                    if (row[i] is IFoodItem)
                    {
                        column = i;
                        return true;
                    }
                }
                return false;
            });
            if (column != -1)
            {
                FoodItemPosition = new Tuple<int, int>(row, column);
                Console.WriteLine("Happy to find food!");

                return true;
            }
            return false;
        }
    }
}
