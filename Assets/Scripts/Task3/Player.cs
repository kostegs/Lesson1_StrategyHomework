using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Task3
{
    public class Player : MonoBehaviour
    {
        const int DEFAULT_REPUTATION = 100;

        [SerializeField] Camera _currentCamera;
        [SerializeField] float _speed;

        public int Reputation { get; private set; }

        public event EventHandler<PlayerReputationEventArgs> ReputationChanged;

        private Vector3 _target;
        private bool _isMoving;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (EventSystem.current.IsPointerOverGameObject())
                    return;                    

                Ray ray = _currentCamera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit raycastHit))
                    _target = new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z);

                _isMoving = true;
            }

            if (_isMoving && (transform.position - _target).sqrMagnitude <= 0.1)
                _isMoving = false;

            if (_isMoving)
            {
                Vector3 direction = _target - transform.position;
                transform.Translate(direction.normalized * _speed * Time.deltaTime);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Bonus bonus))
            {
                Reputation += bonus.Count;
                ReputationChanged.Invoke(this, new PlayerReputationEventArgs(Reputation));
                Destroy(other.gameObject);
            }
        }

        public void Initialize(UIStorage uiStorage)
        {
            Reputation = DEFAULT_REPUTATION;

            ReputationChanged += uiStorage.PlayerReputation.OnReputationChanged;
            ReputationChanged.Invoke(this, new PlayerReputationEventArgs(Reputation));
        }
    }
}
