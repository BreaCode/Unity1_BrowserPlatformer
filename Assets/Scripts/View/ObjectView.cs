using UnityEngine;

namespace U1BrowserPlatformer
{
    internal class ObjectView : MonoBehaviour
    {
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Material _material;

        public Transform PlayerTransform
        {
            get { return _playerTransform; }
        }
        public SpriteRenderer SpriteRenderer
        {
            get { return _spriteRenderer; }
        }
        public Material Material
        {
            get { return _material; }
        }

    }
}

