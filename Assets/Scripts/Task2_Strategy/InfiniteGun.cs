using UnityEngine;

namespace Task2.Strategy
{
    public class InfiniteGun : IShooter
    {
        public int AmmoCount { get; private set; }

        public void Shot(Transform shootingPoint, GameObject bulletPrefab, float ttl)
        {
            Debug.Log("Выстрел из ружья с бесконечными патронами");
        }

        public void ShotParticleEffect(ParticleSystem particleSystem)
        {
            Debug.Log("Спецэффект выстрела из ружья с бесконечными патронами");
        }

        public void ShotSFX(AudioSource audioSource)
        {
            Debug.Log("Звук выстрела из ружья с бесконечными патронами");
        }
    }
}
