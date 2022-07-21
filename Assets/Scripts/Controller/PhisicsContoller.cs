using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    internal sealed class PhisicsContoller : IController, IInitialization, IFixedExecute
    {
        private List<IPhisicsObjectView> _phisicsObjectsList;
        internal PhisicsContoller(PhisicsObjectsList phisicsObjectsList)
        {
            _phisicsObjectsList = phisicsObjectsList.PhisicsObjectViews;
        }

        public void Initialization()
        {
            foreach (IPhisicsObjectView phisicsObjectView in _phisicsObjectsList)
            {
                Vector3 lowerPosition = phisicsObjectView.Transform.position;
                lowerPosition.y = lowerPosition.y + phisicsObjectView.FloorYPosition;
                phisicsObjectView.IsGrounded = GroundCheck(lowerPosition);
            }
        }

        public void FixedExecute(float deltaTime)
        {
            foreach (IPhisicsObjectView phisicsObjectView in _phisicsObjectsList)
            {

                if (phisicsObjectView.IsGrounded == false)
                {
                    phisicsObjectView.Transform.position = new Vector3(phisicsObjectView.Transform.position.x, phisicsObjectView.Transform.position.y - 0.09f * phisicsObjectView.Mass, phisicsObjectView.Transform.position.z);
                    Vector3 lowerPosition = phisicsObjectView.Transform.position;
                    lowerPosition.y = lowerPosition.y + phisicsObjectView.FloorYPosition;
                    phisicsObjectView.IsGrounded = GroundCheck(lowerPosition);
                }
            }
        }

        internal bool GroundCheck(Vector3 lowerPosition)
        {
            bool isGrounded = false;
            RaycastHit2D hit = Physics2D.Raycast(lowerPosition, -Vector2.up);
            float distance = 1;
            if (hit.collider != null)
            {
                distance = Mathf.Abs(hit.point.y - lowerPosition.y);
            }
            else
            {
                isGrounded = false;
            }
            if (distance < 0.005f)
            {
                isGrounded = true;
            }
            return isGrounded;
        }
    }
}

