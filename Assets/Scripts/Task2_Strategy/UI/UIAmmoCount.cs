using TMPro;
using UnityEngine;

namespace Task2.Strategy
{
    public class UIAmmoCount : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _ammoCountText;

        public void OnAmmoChanged(object sender, EventArgsAmmoCount eventArgs) =>        
            _ammoCountText.text = $"Количество патронов: {eventArgs.AmmoCount}";
        
    }
}
