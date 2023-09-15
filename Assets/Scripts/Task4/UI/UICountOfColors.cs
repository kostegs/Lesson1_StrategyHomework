using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Task4
{
    public class UICountOfColors : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _countOfColorsText;

        public void OnCountChanged(object sender, SphereEventArgs eventAargs)
        {
            IEnumerable countOfColors = eventAargs.CountOfColors;
            string text = "Количество шаров по цветам: ";
            
            foreach (var KeyValue in countOfColors as Dictionary<SphereColors, int>)
            {
                text += $"{KeyValue.Key}: {KeyValue.Value} | ";
            }

            _countOfColorsText.text = text; 
        }
    }
}
