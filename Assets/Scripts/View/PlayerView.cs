using UnityEngine;


namespace U1BrowserPlatformer
{
    internal sealed class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private Rigidbody2D _playerRigidbody;
        [SerializeField] private Collider2D _collider;
        //Model
        [SerializeField] private float _speed;
        private bool _isGrounded = true;
        public Transform Transform
        {
            get { return _playerTransform; }
        }

        public Rigidbody2D Rigidbody
        {
            get { return _playerRigidbody; }
        }
        public Collider2D Collider
        {
            get { return _collider; }
        }
        public float Speed
        {
            get { return _speed; }
        }
        public bool IsGrounded
        {
            get { return _isGrounded; }
            set { _isGrounded = value; } 
        }
    }
}

