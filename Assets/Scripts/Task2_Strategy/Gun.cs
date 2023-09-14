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

        public void ShotParticleEffect(ParticleSystem particleSystem)
        {
            Debug.Log("Спецэффекты обычного выстрела из обычного ружья");
        }

        public void ShotSFX(AudioSource audioSource)
        {
            Debug.Log("Звук обычного выстрела из обычного ружья");
        }
    }
}
