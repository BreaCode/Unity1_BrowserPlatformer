using UnityEngine;

namespace U1BrowserPlatformer
{
    internal interface IPhisicsObjectView
    {
        public float Mass { get; }
        public Transform Transform { get; }
        public float FloorYPosition
        { get; }
        public bool IsGrounded
        { get; set; }
    }
}

