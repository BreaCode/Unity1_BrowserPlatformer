using UnityEngine;

namespace U1BrowserPlatformer
{
    public class SceneView : MonoBehaviour, IView
    {
        [SerializeField] internal ObjectView PlayerView;
        [SerializeField] internal ObjectView FireballView;
    }
}

