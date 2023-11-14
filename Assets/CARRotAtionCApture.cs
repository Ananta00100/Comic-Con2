using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CARRotAtionCApture : MonoBehaviour
{

    public GameObject TrackerCube;
    public GameObject CarBody;
    public int CarRotationSpeed;


    public void Update()
      {

            Debug.Log("Cube" + TrackerCube.transform.position.x);

    /*     if(TrackerCube.transform.position.x>0)
            {
                CarBody.transform.Rotate(0,-CarRotationSpeed*Time.deltaTime,0);


            }

          if (TrackerCube.transform.position.x < 0)
             {


                   CarBody.transform.Rotate(0, CarRotationSpeed * Time.deltaTime, 0);   
             }*/




        }
}
