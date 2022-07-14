using System;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    [CreateAssetMenu(fileName = "SpriteAnimationConfig", menuName = "Config / Animation", order = 1)]
    public class AnimationConfig : ScriptableObject
    {
        [Serializable]
        public sealed class SpriteSequence
        {
            public AnimState Track;
            public List<Sprite> Sprites = new List<Sprite>();
        }

        public List<SpriteSequence> Sequences = new List<SpriteSequence>();
    }
}

