using UnityEngine;

namespace U1BrowserPlatformer
{
    internal sealed class ContactChecker
    {
        private ContactPoint2D[] _contactPoints = new ContactPoint2D[5];
        private int _contactCount;
        private float _treshold = 0.2f;

        internal ContactChecker(float treshold)
        {
            _treshold = treshold;
        }
        
        internal bool CheckContact(Collider2D collider)
        {
            _contactCount = collider.GetContacts(_contactPoints);

            for (int i = 0; i < _contactCount; i++)
            {
                if (_contactPoints[i].normal.y > _treshold)
                {
                    Debug.Log("Grounded");
                    return true;
                }  
            }
            return false;
        }

    }
}