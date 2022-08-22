using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    internal sealed class JumpController : IController
    {
        private Rigidbody2D _playerRigidbody;
        private Vector2 _jumpForce = new Vector2(0, 2);


        internal JumpController(SceneView sceneView)
        {
            _playerRigidbody = sceneView.PlayerView.Rigidbody;
        }

        internal void Jump()
        {
            _playerRigidbody.AddForce( Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }

    }
}

