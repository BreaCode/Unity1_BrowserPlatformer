using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U1BrowserPlatformer
{
    internal sealed class PhisicsObjectsList
    {
        internal List<IPhisicsObjectView> PhisicsObjectViews = new List<IPhisicsObjectView>();

        internal PhisicsObjectsList(SceneView sceneView)
        {
            PhisicsObjectViews.Add(sceneView.PlayerView);
        }
    }
}

