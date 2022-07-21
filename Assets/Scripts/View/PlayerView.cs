using UnityEngine;


namespace U1BrowserPlatformer
{
    internal sealed class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private float _floorYPosition;
        [SerializeField] private float _speed;
        private bool _isGrounded = true;

        public Transform PlayerTransform
        {
            get { return _playerTransform; }
        }
        public float FloorYPosition
        {
            get { return _floorYPosition; }
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

