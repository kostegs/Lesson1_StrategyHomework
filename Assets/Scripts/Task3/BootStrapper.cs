using UnityEngine;

namespace Task3
{
    public class BootStrapper : MonoBehaviour
    {
        [SerializeField] private UIStorage _uiStorage;
        [SerializeField] private Trader _trader;
        [SerializeField] private Player _player;

        private void Awake()
        {
            _trader.Initialize(_uiStorage);
            _player.Initialize(_uiStorage);            
        }
    }
}
