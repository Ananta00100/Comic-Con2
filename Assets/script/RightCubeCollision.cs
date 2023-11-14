using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCubeCollision : MonoBehaviour
{


    public DemoScript DemoScript;


    private void OnCollisionEnter(Collision collision)
    {
        DemoScript.num -= 1;
        Debug.Log("RightSipe");
        DemoScript.Change();

        if(DemoScript.num <1)
        {
            DemoScript.num = 9;
        }

    }



}
