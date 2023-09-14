using System;
using UnityEngine;

namespace Task2.Strategy
{
    public class Gun : IShooter
    {
        public int AmmoCount { get; private set; }

        public void Shot(Transform shootingPoint, GameObject bulletPrefab, float ttl)
        {
            Debug.Log("Обычный выстрел из обычного ружья");
        }        
    }
}
