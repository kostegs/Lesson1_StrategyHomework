using TMPro;
using UnityEngine;

namespace Task3
{
    public class UIPlayerReputation : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textReputation;

        public void OnReputationChanged(object sender, PlayerReputationEventArgs eventArgs) =>
            _textReputation.text = $"Репутация игрока: {eventArgs.PlayerReputation} очков";        
}
}
