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

        private IShooter _shootingStrategy;
        private AudioSource _audioSource;
        private ParticleSystem _particleSystem;
        private bool _isActive = false;

        public void Initialize()
        {
            _audioSource = GetComponent<AudioSource>();
            _particleSystem = GetComponent<ParticleSystem>();
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

            _shootingStrategy.Shot(_shotPoint, _bulletPrefab, _ttl);
            
            if (_audioSource != null)
                _shootingStrategy.ShotSFX(_audioSource);

            if (_particleSystem != null)
                _shootingStrategy.ShotParticleEffect(_particleSystem);

        }
    }
}
