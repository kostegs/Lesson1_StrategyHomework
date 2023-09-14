using UnityEngine;

namespace Task2.Template
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] private Transform _shootingPoint;
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private string _weaponName;
        [SerializeField] private int _ammoCount;

        public int AmmoCount => _ammoStorage.AmmoCount;
        public string WeaponName => _weaponName;

        private Strategy.IAmmoStorage _ammoStorage;
        private AudioSource _audioSource;
        private ParticleSystem _particleSystem;

        public void Initialize()
        {
            _ammoStorage = new Strategy.AmmoStorage(_ammoCount);
            _audioSource = GetComponent<AudioSource>();
            _particleSystem = GetComponentInChildren<ParticleSystem>();
        }

        public void Fire()
        {
            if (AmmoCount <= 0)
                return;

            Shot(_shootingPoint, _bulletPrefab, _ammoStorage);
            SFX();
            ShootingEffect();
        }

        public abstract void Shot(Transform shootingPoint, GameObject _bulletPrefab, Strategy.IAmmoStorage ammoStorage);

        public virtual void SFX()
        {
            if (_audioSource == null && _audioSource.clip == null)
                return;

            _audioSource.Play();
        }

        public virtual void ShootingEffect()
        {
            if (_particleSystem == null)
                return;

            _particleSystem.Play();
        }
    }
}
