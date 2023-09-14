using UnityEngine;

namespace Task2.Strategy
{
    public class Gun : IShooter
    {
        public int AmmoCount { get; private set; }

        public void Shot(Transform shootingPoint, GameObject bulletPrefab, IAmmoStorage ammoStorage)
        {
            MonoBehaviour.Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
            ammoStorage.DivideAmmo(1);
        }        
    }
}
