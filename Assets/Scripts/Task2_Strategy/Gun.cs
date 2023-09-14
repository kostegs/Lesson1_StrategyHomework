using UnityEngine;

namespace Task2.Strategy
{
    public class Gun : IShooter
    {
        public int AmmoCount { get; private set; }

        public void Shot(Transform shootingPoint, GameObject bulletPrefab, float ttl)
        {
            Debug.Log("������� ������� �� �������� �����");
        }

        public void ShotParticleEffect(ParticleSystem particleSystem)
        {
            Debug.Log("����������� �������� �������� �� �������� �����");
        }

        public void ShotSFX(AudioSource audioSource)
        {
            Debug.Log("���� �������� �������� �� �������� �����");
        }
    }
}
