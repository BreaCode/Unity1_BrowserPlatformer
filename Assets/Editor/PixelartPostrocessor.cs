using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class PixelartPostrocessor : AssetPostprocessor
{
    private void OnPostprocessTexture(Texture2D texture)
    {
        var fileName = Path.GetFileNameWithoutExtension(assetPath);
        float tWidth = texture.width;
        float tHeight = texture.height;
        Rect tRect = new Rect(0, 0, tWidth, tHeight);
        Sprite spriteAsset = Sprite.Create(texture, tRect, new Vector2(tWidth / 2, tHeight / 2), tWidth, 1, 0, Vector4.zero, false);
        AssetDatabase.CreateAsset(spriteAsset, Path.Combine(Path.GetDirectoryName(assetPath), $"{fileName}.asset"));
    }
}
