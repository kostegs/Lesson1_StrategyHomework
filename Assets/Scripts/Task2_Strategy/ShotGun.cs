using UnityEngine;

namespace Task2.Strategy
{
    public class ShotGun : IShooter
    {
        public void Shot(Transform shootingPoint, GameObject bulletPrefab, IAmmoStorage ammoStorage)
        {
            int counterMax = ammoStorage.AmmoCount < 3 ? ammoStorage.AmmoCount : 3;

            for (int i = 0; i < counterMax; i++)            
                MonoBehaviour.Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
            
            ammoStorage.DivideAmmo(counterMax);          

        }
    }
}
