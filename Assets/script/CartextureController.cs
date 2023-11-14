using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartextureController : MonoBehaviour
{


    private static CartextureController instance;
    private static CartextureController cartextureController
    {
        get {
            GameObject cartexture = GameObject.Find("CarTextureController");        
            return instance;
        }
    }
    public GameObject[] CarPrefabs;
    // Update is called once per frame
    void Update()
    {
    }
}
