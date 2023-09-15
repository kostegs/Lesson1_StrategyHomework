using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task4
{
    public abstract class Sphere : MonoBehaviour
    {
        [SerializeField] private SphereColors _color;

        private static Dictionary<SphereColors, int> _countOfColors;

        // TODO - Initialize
        private void Awake()
        {
            if (_countOfColors == null)
                _countOfColors = new Dictionary<SphereColors, int>();

            if (_countOfColors.ContainsKey(_color))
                _countOfColors[_color] += 1;            
            else
                _countOfColors.Add(_color, 1);

            foreach (var numberOfColors in _countOfColors)
                Debug.Log($"Color: {numberOfColors.Key} count: {numberOfColors.Value}");
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent<Player>(out _))
                Destroy(gameObject);
        }

        private void OnDestroy()
        {
            if (_countOfColors.ContainsKey(_color))
                _countOfColors[_color] -= 1;

            foreach (var numberOfColors in _countOfColors)
                Debug.Log($"Color: {numberOfColors.Key} count: {numberOfColors.Value}");
        }
    }
}
