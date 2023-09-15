using UnityEngine;

namespace Task4
{
    public class BootStrapper : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [Header("UI")]
        [SerializeField] private UICountOfColors _uiCountOfColors;        
        [SerializeField] private GameObject _panelChoosingStrategy;
        [SerializeField] private GameObject _panelWinning;        

        IWinningStrategy _winningStrategy;

        private void Awake()
        {
            Sphere.Initialization();
            Sphere.CountOfColorsChanged += _uiCountOfColors.OnCountChanged;
            Sphere.CountOfColorsChanged += CheckWinning;
            UiButtonChooseStrategy.StrategyChoosen += OnStrategyChoosen;            
        }

        public void OnStrategyChoosen(object sender, StrategyEventArgs eventArgs)
        {
            var winningStrategy = eventArgs.WinningStrategy;

            switch (winningStrategy)
            {
                case EnumWinningStrategy.DestroyAllColors:
                    _winningStrategy = new Strategy_DestroyAll();
                    break;
                case EnumWinningStrategy.DestroyAllElementsOfOneColor:
                    _winningStrategy = new Strategy_DestroyAllOneColor();
                    break;
            }

            _panelChoosingStrategy.SetActive(false);
            _player.gameObject.SetActive(true);
        }

        public void CheckWinning(object sender, SphereEventArgs eventArgs)
        {
            if (_winningStrategy != null)
            {
                bool isWin = _winningStrategy.CheckWinning(eventArgs.CountOfColors);

                if (isWin)
                {
                    _panelWinning.SetActive(true);
                    _player.gameObject.SetActive(false);
                }
                
            }

        }
    }
}
