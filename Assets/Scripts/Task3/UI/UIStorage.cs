using UnityEngine;

namespace Task3
{
    public class UIStorage : MonoBehaviour
    {
        [SerializeField] private GameObject _noTradePanel;
        [SerializeField] private GameObject _tradeArmorPanel;
        [SerializeField] private GameObject _tradeFruitPanel;
        [SerializeField] private UIPlayerReputation _playerReputation;

        public GameObject NoTradePanel => _noTradePanel;
        public GameObject TradeArmorPanel => _tradeArmorPanel;
        public GameObject TradeFruitPanel => _tradeFruitPanel;

        public UIPlayerReputation PlayerReputation => _playerReputation;

    }
}
