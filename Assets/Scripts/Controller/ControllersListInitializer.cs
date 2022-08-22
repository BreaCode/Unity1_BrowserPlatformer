namespace U1BrowserPlatformer
{
    internal sealed class ControllersListInitializer
    {
        internal static void InitializeControllers(Controllers controllers, SceneView sceneView)
        {
            AnimationControlers animationControlers = new AnimationControlers(sceneView);
            InputController inputController = new InputController();
            JumpController jumpController = new JumpController(sceneView);
            MovementController movementController = new MovementController(sceneView, inputController, jumpController);

            controllers.Add(animationControlers);
            controllers.Add(inputController);
            controllers.Add(jumpController);
            controllers.Add(movementController);
        }
    }
}

