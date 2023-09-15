using System;
using System.Collections.Generic;
using UnityEngine;

namespace Task4
{
    public abstract class Sphere : MonoBehaviour
    {
        [SerializeField] private SphereColors _color;

        private static Dictionary<SphereColors, int> _countOfColors;

        public static event EventHandler<SphereEventArgs> CountOfColorsChanged;

        private void Awake()
        {
            if (_countOfColors.ContainsKey(_color))
                _countOfColors[_color] += 1;            
            else
                _countOfColors.Add(_color, 1);
        }

        private void Start() => CountOfColorsChanged?.Invoke(this, new SphereEventArgs(_countOfColors));

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent<Player>(out _))
                Destroy(gameObject);

            if (_countOfColors.ContainsKey(_color))
                _countOfColors[_color] -= 1;

            CountOfColorsChanged?.Invoke(this, new SphereEventArgs(_countOfColors));
        }

        public static void Initialization()
        {
            _countOfColors = new Dictionary<SphereColors, int>();
        }


    }
}
