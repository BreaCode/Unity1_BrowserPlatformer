using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    internal sealed class MovementController : IController, IFixedExecute
    {
        private ObjectView _playerObjectView;
        private Transform _playerTransform;
        private InputController _inputController;
        private JumpController _jumpController;
        private PhisicsContoller _phisicsContoller;

        internal MovementController(SceneView scene, InputController inputController, PhisicsContoller phisicsContoller, JumpController jumpController)
        {
            _playerObjectView = scene.PlayerView;
            _playerTransform = _playerObjectView.Transform;
            _inputController = inputController;
            _jumpController = jumpController;
            _phisicsContoller = phisicsContoller;
        }

        public void FixedExecute(float deltaTime)
        {
            float xAxis = _inputController.XAxis;
            if (_inputController.DoJump == true && _playerObjectView.IsGrounded == true)
            {
                _jumpController.Ticks = 30;
            }
            float xPosition = _playerTransform.position.x + xAxis * _playerObjectView.Speed;
            _playerTransform.position = new Vector3(xPosition, _playerTransform.position.y);
            Vector3 lowerPosition = _playerTransform.position;
            lowerPosition.y = lowerPosition.y + _playerObjectView.FloorYPosition;
            _playerObjectView.IsGrounded = _phisicsContoller.GroundCheck(lowerPosition);
        }
    }
}

