using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTerrainLayerDiffuseTexture : MonoBehaviour
{
    public TerrainLayer TerrainLayer;
    public Texture2D DiffuseTexture;

    void Start()
    {
        if (TerrainLayer != null && DiffuseTexture != null)
            TerrainLayer.diffuseTexture = DiffuseTexture;
    }
}
