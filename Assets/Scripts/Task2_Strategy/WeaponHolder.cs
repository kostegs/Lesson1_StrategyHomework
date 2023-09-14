using System.Collections.Generic;
using UnityEngine;
using System;

namespace Task2.Strategy
{
    public class WeaponHolder : MonoBehaviour
    {
        [SerializeField] private List<Weapon> _weapons;
        public Weapon CurrentWeapon { get; private set; }

        private Queue<Weapon> _weaponsQueue = new Queue<Weapon>();
        private bool _isActive = false;
        
        private void Update()
        {
            if (_isActive && Input.GetKeyDown(KeyCode.Mouse1))
                SwitchWeapon();
        }

        public void Initialize()
        {
            FillWeaponsQueue();
            SwitchWeapon();
            _isActive = true;
        }

        void FillWeaponsQueue()
        {
            foreach (var weapon in _weapons)
            {
                weapon.Initialize();

                switch (weapon.WeaponType)
                {
                    case WeaponType.Gun:
                        weapon.SetShootingStrategy(new Gun());
                        break;
                    case WeaponType.InfiniteGun:
                        weapon.SetShootingStrategy(new InfiniteGun());
                        break;
                    case WeaponType.ShotGun:
                        weapon.SetShootingStrategy(new ShotGun());
                        break;
                    default:
                        throw new ArgumentNullException(nameof(weapon.WeaponType));
                }                   
                
                _weaponsQueue.Enqueue(weapon);
            }
        }

        void SwitchWeapon()
        {
            CurrentWeapon?.gameObject.SetActive(false);
            CurrentWeapon = _weaponsQueue.Dequeue();
            _weaponsQueue.Enqueue(CurrentWeapon);
            CurrentWeapon.gameObject.SetActive(true);
            Debug.Log($"Current weapon switched. Curren weapon is {CurrentWeapon.WeaponName}");
        }

    }
}
