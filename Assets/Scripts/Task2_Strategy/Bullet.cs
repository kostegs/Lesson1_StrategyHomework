using UnityEngine;

namespace Task2.Strategy
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private int _speed;

        private void Awake()
        {
            GetComponent<Rigidbody>().velocity = transform.forward * _speed;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<Bullet>() != null)
                return;

            Destroy(gameObject);
        }
    }
}
