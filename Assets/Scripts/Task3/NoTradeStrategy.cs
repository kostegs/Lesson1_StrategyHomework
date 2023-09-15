namespace Task3
{
    public class NoTradeStrategy : ITradingStrategy
    {
        private UIStorage _uiStorage;

        public NoTradeStrategy(UIStorage uiStorage) => _uiStorage = uiStorage;

        public void StartTrade() => _uiStorage.NoTradePanel.SetActive(true); 

        public void StopTrade() => _uiStorage.NoTradePanel.SetActive(false);
        
    }
}
