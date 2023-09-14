using UnityEngine;

namespace Task2.Template
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private WeaponHolder _weaponHolder;
        [SerializeField] private Strategy.UIAmmoCount _uiAmmoCount;
        [SerializeField] private Strategy.UICurrentWeapon _uiCurrentWeapon;

        private void Awake()
        {
            _weaponHolder.CurrentWeaponChanged += _uiCurrentWeapon.OnWeaponChanged;
            _weaponHolder.AmmoChanged += _uiAmmoCount.OnAmmoChanged;
            _weaponHolder.Initialize();
        }
    }
}
