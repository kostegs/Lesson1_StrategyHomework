namespace Task2.Strategy
{
    public class AmmoStorage : IAmmoStorage
    {
        public int AmmoCount => _ammoStorage;

        private int _ammoStorage;

        public AmmoStorage(int ammoStorage) => _ammoStorage = ammoStorage < 0 ? 0 : ammoStorage;

        public void AddAmmo(int amount) => _ammoStorage += amount;        

        public void DivideAmmo(int amount)
        {
            if (_ammoStorage < amount)
                _ammoStorage = 0;
            else
                _ammoStorage -= amount;
        }        
    }
}
