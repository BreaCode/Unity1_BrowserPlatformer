using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    internal sealed class MovementController : IController, IFixedExecute
    {
        private ObjectView _playerObjectView;
        private Transform _playerTransform;
        private Rigidbody2D _playerRigidBody;
        private Collider2D _playerCollider;
        private InputController _inputController;
        private JumpController _jumpController;

        private Vector3 _leftScale = new Vector3(-1, 1, 1);
        private Vector3 _rightScale = new Vector3(1, 1, 1);
        private float _movingTreshold = 0.1f;
        
        private float _xVelocity;
        private float _yVelocity;
        private ContactChecker _contactChecker = new ContactChecker(0.2f);

        internal MovementController(SceneView scene, InputController inputController, JumpController jumpController)
        {
            _playerObjectView = scene.PlayerView;
            _playerTransform = _playerObjectView.Transform;
            _playerRigidBody = _playerObjectView.Rigidbody;
            _playerCollider = _playerObjectView.Collider;
            _inputController = inputController;
            _jumpController = jumpController;
        }

        public void FixedExecute(float deltaTime)
        {
            float xAxis = _inputController.XAxis;
            _yVelocity = _playerRigidBody.velocity.y;

            if (Mathf.Abs(xAxis) > _movingTreshold)
            {
                MoveTowards(xAxis);
            }

            if (_inputController.DoJump == true && _playerObjectView.IsGrounded == true)
            {
                _jumpController.Jump();
            }
            
            _playerObjectView.IsGrounded = _contactChecker.CheckContact(_playerCollider);
        }

        private void MoveTowards(float xAxis)
        {
            _xVelocity = Time.fixedDeltaTime * _playerObjectView.Speed * (xAxis < 0 ? -1 : 1);
            _playerRigidBody.velocity = new Vector2(_xVelocity, _playerRigidBody.velocity.y);
            _playerTransform.localScale = xAxis < 0 ? _leftScale : _rightScale;
        }
    }
}

