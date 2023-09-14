using UnityEngine;

namespace Task2.Template
{
    public class StandartGun : Weapon
    {
        public override void Shot(Transform shootingPoint, GameObject bulletPrefab, Strategy.IAmmoStorage ammoStorage)
        {
            Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
            ammoStorage.DivideAmmo(1);
        }        
    }
}
