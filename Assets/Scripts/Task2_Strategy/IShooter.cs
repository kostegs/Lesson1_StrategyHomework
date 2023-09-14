using UnityEngine;

namespace Task2.Strategy
{
    public interface IShooter
    {
        int AmmoCount { get; }
        void Shot(Transform shootingPoint, GameObject bulletPrefab, IAmmoStorage ammoStorage);
    }
}
