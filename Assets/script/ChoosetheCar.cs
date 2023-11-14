using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoosetheCar : MonoBehaviour
{
 


    public UnityEngine.SceneManagement.Scene[] Carscenes;

   


   public void ChhoseCarModel(int num)
    {
        SceneManager.LoadScene(num);
    }




   
}
