using UnityEngine;

namespace Task4
{
    public class Player : MonoBehaviour
    {
        [SerializeField] Camera _currentCamera;
        [SerializeField] float _speed;

        Vector3 _target;
        bool _isMoving;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
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

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(Vector3.zero, _target);
        }
    }
}
