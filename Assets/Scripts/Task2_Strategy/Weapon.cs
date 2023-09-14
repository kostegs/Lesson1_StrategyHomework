using UnityEngine;
using System;

namespace Task2.Strategy
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private int _ammoCount;
        [SerializeField] private Transform _shotPoint;
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private float _ttl;
        [field: SerializeField] public WeaponType WeaponType { get; private set; }
        [field: SerializeField] public string WeaponName { get; private set; }
        public int AmmoCount => _ammoStorage.AmmoCount;

        private IShooter _shootingStrategy;
        private IAmmoStorage _ammoStorage;
        private bool _isActive = false;
        private AudioSource _audioSource;
        private ParticleSystem _particleSystem;
        
        public void Initialize()
        {
            _audioSource = GetComponent<AudioSource>();
            _particleSystem = GetComponentInChildren<ParticleSystem>();
            _ammoStorage = new AmmoStorage(_ammoCount);
            _isActive = true;
        }

        public void SetShootingStrategy(IShooter strategy)
        {
            _shootingStrategy = strategy;
        }

        public void Fire()
        {
            if (_isActive == false)
                return;

            if (_shootingStrategy == null)
                throw new ArgumentNullException(nameof(_shootingStrategy));

            _shootingStrategy.Shot(_shotPoint, _bulletPrefab, _ammoStorage);
            
            if (AmmoCount != 0)
            {
                SFX();
                ParticleEffect();
            }            
        }

        public void SFX()
        {
            if (_audioSource == null && _audioSource.clip == null) 
                return;

            _audioSource.Play();
        }

        public void ParticleEffect()
        {
            if (_particleSystem == null)
                return;

            _particleSystem.Play();
        }
    }
}
