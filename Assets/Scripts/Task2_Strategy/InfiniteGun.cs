using UnityEngine;

namespace Task2.Strategy
{
    public class InfiniteGun : IShooter
    {
        public void Shot(Transform shootingPoint, GameObject bulletPrefab, IAmmoStorage ammoStorage)
        {
            MonoBehaviour.Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
        }
    }
}
