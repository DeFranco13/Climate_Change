using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public TerrainLayer TerrainLayer;
    public float[] TriggerAt;
    public Texture2D[] DiffuseTexture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<TriggerAt.Length; i++)
        {
            if(TriggerAt[i] <= TickObject.instance.TotalCO2)
            {
                if (TerrainLayer != null)
                    TerrainLayer.diffuseTexture = DiffuseTexture[i];
            }
        }
    }
}
