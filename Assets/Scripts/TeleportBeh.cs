using System.Transactions;
using UnityEngine;

namespace U1BrowserPlatformer
{
    public class TeleportBeh : MonoBehaviour
    {
        [SerializeField] private Transform _destinationTransform;
        private Vector2 _destination;


        private void Awake()
        {
            _destination = (Vector2)_destinationTransform.position;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            other.gameObject.GetComponent<Rigidbody2D>().position = _destination;
        }
    }
}

