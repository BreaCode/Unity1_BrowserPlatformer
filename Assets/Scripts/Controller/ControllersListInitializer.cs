namespace U1BrowserPlatformer
{
    internal sealed class ControllersListInitializer
    {
        internal static void InitializeControllers(Controllers controllers, SceneView sceneView)
        {
            AnimationControlers animationControlers = new AnimationControlers(sceneView);



            controllers.Add(animationControlers);
        }
    }
}

