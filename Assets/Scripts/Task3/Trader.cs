using UnityEngine;

namespace Task3
{
    public class Trader : MonoBehaviour
    {
        private ITradingStrategy _tradingStrategy;
        private UIStorage _uiStorage;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Player player) == false)
                return;

            switch (player.Reputation) 
            {
                case <= 200:
                    _tradingStrategy = new NoTradeStrategy(_uiStorage);
                    break;
                case int pr when (pr > 200 && pr <= 300):
                    _tradingStrategy = new TradeArmorStrategy(_uiStorage);
                    break;
                case > 300:
                    _tradingStrategy = new TradeFruitStrategy(_uiStorage);
                    break;                    
            }                

            if (_tradingStrategy != null)
                _tradingStrategy.StartTrade();                        
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Player player) == false)
                return;

            if (_tradingStrategy != null)
                _tradingStrategy.StopTrade();

        }

        public void Initialize(UIStorage uiStorage) => _uiStorage = uiStorage;

    }
}
