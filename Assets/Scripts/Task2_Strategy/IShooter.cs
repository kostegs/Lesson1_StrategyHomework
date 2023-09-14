using UnityEngine;

namespace Task2.Strategy
{
    public interface IShooter
    {
        void Shot(Transform shootingPoint, GameObject bulletPrefab, IAmmoStorage ammoStorage);
    }
}
