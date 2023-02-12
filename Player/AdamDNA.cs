using x4amcd.Primordials;

namespace x4amcd_Player_Scripts
{
    interface IAdamDNA : IThing
    {
        new public int Value { get; set; }
        void SeeWorld();
        void RememberWorld();
        void AbstractWorld();

        void ModelWorld();

        void ChooseWorld();

        void ActOnWorld();
    }

}