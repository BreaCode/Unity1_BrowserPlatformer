using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace U1BrowserPlatformer
{
    public class TestUI : MonoBehaviour
    {
        [SerializeField] private SceneView _sceneView;

        private Material _fireballMaterial;
        [SerializeField] private Button _fireballSkinButtonDefault;
        [SerializeField] private Button _fireballSkinButtonRed;
        [SerializeField] private Button _fireballSkinButtonGreen;
        [SerializeField] private Button _fireballSkinButtonBlue;

        private Material _playerMaterial;
        [SerializeField] private Button _playerSkinButtonGreen;
        [SerializeField] private Button _playerSkinButtonOrange;

        private void OnEnable()
        {
            _fireballMaterial = _sceneView.FireballView.Material;
            _playerMaterial = _sceneView.PlayerView.Material;

            _fireballSkinButtonDefault.onClick.AddListener(() => OnButtonClick(_fireballMaterial, ConstantResourcesPaths.FIREBALL_SKIN_DEFAULT_RESOURCE_PATH));
            _fireballSkinButtonRed.onClick.AddListener(() => OnButtonClick(_fireballMaterial, ConstantResourcesPaths.FIREBALL_SKIN_RED_RESOURCE_PATH));
            _fireballSkinButtonGreen.onClick.AddListener(() => OnButtonClick(_fireballMaterial, ConstantResourcesPaths.FIREBALL_SKIN_GREEN_RESOURCE_PATH));
            _fireballSkinButtonBlue.onClick.AddListener(() => OnButtonClick(_fireballMaterial, ConstantResourcesPaths.FIREBALL_SKIN_BLUE_RESOURCE_PATH));

            _playerSkinButtonGreen.onClick.AddListener(() => OnButtonClick(_playerMaterial, ConstantResourcesPaths.PLAYER_SKIN_DEFAULT_RESOURCE_PATH));
            _playerSkinButtonOrange.onClick.AddListener(() => OnButtonClick(_playerMaterial, ConstantResourcesPaths.PLAYER_SKIN_ORANGE_RESOURCE_PATH));
        }

        private void OnButtonClick(Material targetMaterial, string skinPath)
        {
            targetMaterial.SetTexture("_SkinTex", Resources.Load<Sprite>(skinPath).texture);
        }

        private void OnDisable()
        {
            
        }



    }
}

