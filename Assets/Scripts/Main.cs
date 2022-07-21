using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private SceneView _sceneView;
        private Controllers _controllers = new Controllers();

        private void Awake()
        {
            ControllersListInitializer.InitializeControllers(_controllers, _sceneView);
            _controllers.Initialization();
        }
        private void Update()
        {
            _controllers.Execute(Time.deltaTime);
        }
        private void FixedUpdate()
        {
            _controllers.FixedExecute(Time.fixedDeltaTime);
        }

    }
}

