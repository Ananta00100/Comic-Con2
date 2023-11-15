using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMainManager : MonoBehaviour
{

    public GameObject FrontCube;
    public GameObject RightCube;
    public GameObject LeftCube;

   
    public void ONPalmUP()
    {
        FrontCube.SetActive(true);
       RightCube.GetComponent<RightCollider>().Num = 0;
        LeftCube.GetComponent<LeftCollider>().Num = 0;
    }



}
