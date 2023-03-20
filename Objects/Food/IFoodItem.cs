using x4amcd.Primordials;

namespace x4amcd.Objects.Food
{
    public interface IFoodItem : IThing
    {
        new int Value { get; set; }
    }
}