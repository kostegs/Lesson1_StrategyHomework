using TMPro;
using UnityEngine;

namespace Task2.Strategy
{
    public class UICurrentWeapon : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _currentAmmoText;

        public void OnWeaponChanged(object sender, EventArgsCurrentWeapon eventArgs) =>
            _currentAmmoText.text = $"Текущее оружие: {eventArgs.CurrentWeapon}";
    }
}
