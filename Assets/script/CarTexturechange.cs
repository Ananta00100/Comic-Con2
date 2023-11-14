using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTexturechange : MonoBehaviour
{
    public GameObject carGameObj;
    [SerializeField] private Material[] carMatereals;
    public Material carMatereal;
    public void ChangeCarTexture()
    {
      carMatereal=  carGameObj.GetComponent<Renderer>().material;
        if(Input.GetKeyDown(KeyCode.S))
        {
            carMatereal = carMatereals[0];
        }
    }


}
