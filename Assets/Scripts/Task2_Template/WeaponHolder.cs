using System;
using System.Collections.Generic;
using UnityEngine;

namespace Task2.Template
{
    public class WeaponHolder : MonoBehaviour
    {
        [SerializeField] private List<Weapon> _weapons;

        public Weapon CurrentWeapon { get; private set; }

        public event EventHandler<Strategy.EventArgsCurrentWeapon> CurrentWeaponChanged;
        public event EventHandler<Strategy.EventArgsAmmoCount> AmmoChanged;

        private Queue<Weapon> _weaponsQueue = new Queue<Weapon>();
        private bool _isActive = false;

        private void Update()
        {
            if (_isActive && Input.GetKeyDown(KeyCode.Mouse1))
                SwitchWeapon();
        }

        public void Initialize()
        {
            InitializeWeapons();
            SwitchWeapon();
            _isActive = true;
        }

        public void Fire()
        {
            CurrentWeapon.Fire();
            AmmoChanged?.Invoke(this, new Strategy.EventArgsAmmoCount(CurrentWeapon.AmmoCount));
        }

        void InitializeWeapons()
        {
            foreach (var weapon in _weapons)
            {
                weapon.Initialize();               
                _weaponsQueue.Enqueue(weapon);
            }
        }

        void SwitchWeapon()
        {
            CurrentWeapon?.gameObject.SetActive(false);
            CurrentWeapon = _weaponsQueue.Dequeue();
            _weaponsQueue.Enqueue(CurrentWeapon);
            CurrentWeapon.gameObject.SetActive(true);
            CurrentWeaponChanged?.Invoke(this, new Strategy.EventArgsCurrentWeapon(CurrentWeapon.WeaponName));
            AmmoChanged?.Invoke(this, new Strategy.EventArgsAmmoCount(CurrentWeapon.AmmoCount));
        }
    }
}
