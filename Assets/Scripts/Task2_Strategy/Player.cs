using UnityEngine;

namespace Task2.Strategy
{
    public class Player : MonoBehaviour
    {
        [SerializeField] WeaponHolder _weaponHolder;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                _weaponHolder.Fire();                    
        }
    }
}
