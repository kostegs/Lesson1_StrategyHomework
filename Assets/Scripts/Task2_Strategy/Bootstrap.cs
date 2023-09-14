using UnityEngine;

namespace Task2.Strategy
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private WeaponHolder _weaponHolder;
        [SerializeField] private UIAmmoCount _uiAmmoCount;
        [SerializeField] private UICurrentWeapon _uiCurrentWeapon;

        private void Awake()
        {
            _weaponHolder.CurrentWeaponChanged += _uiCurrentWeapon.OnWeaponChanged;
            _weaponHolder.AmmoChanged += _uiAmmoCount.OnAmmoChanged;
            _weaponHolder.Initialize();            
        }
    }
}
