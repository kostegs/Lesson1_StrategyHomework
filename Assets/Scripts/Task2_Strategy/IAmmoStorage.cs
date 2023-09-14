namespace Task2.Strategy
{
    public interface IAmmoStorage
    {
        int AmmoCount { get; }
        
        void AddAmmo(int amount);
        void DivideAmmo(int amount);
    }
}
