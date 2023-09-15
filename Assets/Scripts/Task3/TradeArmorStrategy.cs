namespace Task3
{
    public class TradeArmorStrategy : ITradingStrategy
    {
        private UIStorage _uiStorage;

        public TradeArmorStrategy(UIStorage uiStorage) => _uiStorage = uiStorage;

        public void StartTrade() => _uiStorage.TradeArmorPanel.SetActive(true);

        public void StopTrade() => _uiStorage.TradeArmorPanel.SetActive(false);
    }
}
