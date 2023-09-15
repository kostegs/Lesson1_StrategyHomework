using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task4
{
    public class BootStrapper : MonoBehaviour
    {
        [SerializeField] private UICountOfColors _uiCountOfColors;

        private void Awake()
        {
            Sphere.Initialization();
            Sphere.CountOfColorsChanged += _uiCountOfColors.OnCountChanged;
        }
    }
}
