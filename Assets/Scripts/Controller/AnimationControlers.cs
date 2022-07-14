using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    internal sealed class AnimationControlers : IController, IInitialization, IExecute
    {
        private List<SpriteAnimatorController> _animationControllersList = new List<SpriteAnimatorController>();
        private ObjectView _playerView;
        private ObjectView _fireballView;

        internal AnimationControlers(SceneView sceneView)
        {
            _playerView = sceneView.PlayerView;
            _fireballView = sceneView.FireballView;
        }

        public void Initialization()
        {
            CreateAnimControllersList();
        }

        public void Execute(float deltaTime)
        {
            foreach (SpriteAnimatorController animationController in _animationControllersList)
            {
                animationController.Update();
            }
        }

        private List<string> CreateAnimConfigPathsList()
        {
            List<string> animConfigPaths = new List<string>();

            animConfigPaths.Add(ConstantResourcesPaths.PLAYER_ANIMATION_CONFIG_RESOURCE_PATH);
            animConfigPaths.Add(ConstantResourcesPaths.FIREBALL_ANIMATION_CONFIG_RESOURCE_PATH);

            return animConfigPaths;
        }
        private void CreateAnimControllersList()
        {
            AnimationConfig config;
            SpriteAnimatorController spriteAnimator;
            List<string> animConfigPaths = CreateAnimConfigPathsList();
            //Здесь надо как-то сделать это для списка из конфигов
            config = Resources.Load<AnimationConfig>(ConstantResourcesPaths.PLAYER_ANIMATION_CONFIG_RESOURCE_PATH);
            spriteAnimator = new SpriteAnimatorController(config);
            spriteAnimator.StartAnimation(_playerView.SpriteRenderer, AnimState.Walk, true, 10);

            _animationControllersList.Add(spriteAnimator);

            config = Resources.Load<AnimationConfig>(ConstantResourcesPaths.FIREBALL_ANIMATION_CONFIG_RESOURCE_PATH);
            spriteAnimator = new SpriteAnimatorController(config);
            spriteAnimator.StartAnimation(_fireballView.SpriteRenderer, AnimState.Walk, true, 10);

            _animationControllersList.Add(spriteAnimator);
        }
    }

}
