using UnityEngine;

namespace U1BrowserPlatformer
{
    internal class ObjectView : MonoBehaviour, IPhisicsObjectView
    {
        [SerializeField] private Transform _transform;
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Material _material;
        [SerializeField] private float _mass;
        [SerializeField] private float _floorYPosition;
        [SerializeField] private float _speed;
        private bool _isGrounded = true;

        public Transform Transform
        {
            get { return _transform; }
        }
        public SpriteRenderer SpriteRenderer
        {
            get { return _spriteRenderer; }
        }
        public Material Material
        {
            get { return _material; }
        }
        public float Mass 
        { 
            get { return _mass; }
        }
        public float FloorYPosition
        {
            get { return _floorYPosition; }
        }
        public bool IsGrounded
        {
            get { return _isGrounded; }
            set { _isGrounded = value; }
        }
        public float Speed
        {
            get { return _speed; }
        }
    }
}

