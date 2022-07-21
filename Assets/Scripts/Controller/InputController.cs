using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    internal sealed class InputController : IController, IExecute
    {
        private float _xAxis;
        private bool _doJump = false;
        private bool _doCroach = false;

        public float XAxis
        {
            get { return _xAxis; }
        }
        public bool DoJump
        {
            get { return _doJump; }
        }
        public bool DoCroach
        {
            get { return _doCroach; }
        }

        public void Execute(float deltaTime)
        {
            _xAxis = Input.GetAxis("Horizontal");
            float verticalAxisDelta = Input.GetAxis("Vertical");
            _doJump = verticalAxisDelta > 0;
            _doCroach = verticalAxisDelta < 0;
        }
    }
}

