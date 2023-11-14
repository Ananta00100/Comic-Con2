using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    public GameObject GameMager;
    public GameObject leftCube;
   // public GameObject aLeftGameobj;

    public void ONPalmClose()
    {
     //  leftCube.SetActive(false);
        Debug.Log("Close");
        GameMager.GetComponent<CArBAsicRotation>().enabled=false;
        GameMager.GetComponent<CarMotionCapture>().enabled=true;
    }
    public void ONPalmOpen()
    {
       //leftCube.SetActive(true);
        Debug.Log("Open");
        GameMager.GetComponent<CArBAsicRotation>().enabled = true;
        GameMager.GetComponent<CarMotionCapture>().enabled = false;




    }
}
