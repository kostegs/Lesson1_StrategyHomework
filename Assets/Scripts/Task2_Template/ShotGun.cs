using UnityEngine;

namespace Task2.Template
{
    public class ShotGun : Weapon
    {
        public override void Shot(Transform shootingPoint, GameObject bulletPrefab, Strategy.IAmmoStorage ammoStorage)
        {
            int counterMax = ammoStorage.AmmoCount < 3 ? ammoStorage.AmmoCount : 3;

            for (int i = 0; i < counterMax; i++)
                MonoBehaviour.Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);

            ammoStorage.DivideAmmo(counterMax);
        }
    }
}
