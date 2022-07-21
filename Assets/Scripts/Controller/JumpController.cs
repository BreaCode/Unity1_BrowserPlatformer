using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    internal sealed class JumpController : IController, IFixedExecute
    {
        private Transform _playerTransform;
        private int _ticks;

        public int Ticks
        {
            set
            {
                if (_ticks >= 0)
                {
                    _ticks = value;
                }
                else
                {
                    _ticks = 0;
                }
            }
        }

        internal JumpController(SceneView sceneView)
        {
            _playerTransform = sceneView.PlayerView.Transform;
        }

        public void FixedExecute(float deltaTime)
        {
            if (_ticks > 0)
            {
                _ticks--;
                _playerTransform.position = new Vector3(_playerTransform.position.x, _playerTransform.position.y + 0.18f, _playerTransform.position.z);
            }
        }

    }
}

