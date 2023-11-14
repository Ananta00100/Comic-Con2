using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oncollision : MonoBehaviour
{


    public Animator SecoundCar;

    public GameObject MainCube;

      
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Top");

        SecoundCar.SetTrigger("OnClick");
       
     //   SceneManager.LoadScene(10);

    }

 

    public void OnPalmClose()
    {

    }

}
