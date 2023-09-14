using UnityEngine;

namespace Task2.Strategy
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private WeaponHolder _weaponHolder;

        private void Awake()
        {
            _weaponHolder.Initialize();
        }
    }
}
