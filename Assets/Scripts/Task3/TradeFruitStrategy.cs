namespace Task3
{
    public class TradeFruitStrategy : ITradingStrategy
    {
        private UIStorage _uiStorage;

        public TradeFruitStrategy(UIStorage uiStorage) => _uiStorage = uiStorage;

        public void StartTrade() => _uiStorage.TradeFruitPanel.SetActive(true);

        public void StopTrade() => _uiStorage.TradeFruitPanel.SetActive(false);
    }
}
