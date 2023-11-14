using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnUpSipe : MonoBehaviour
{


    public GameObject BaseGAmeObj;


    public GameObject LeftCube;

    public GameObject FiXedPosition;
    public int MovementSpeed;

    public GameObject[] DecalsUIs;


    private void OnCollisionEnter(Collision collision)
    {


        //  BaseGAmeObj.transform.position = Vector3.Slerp(this.transform.position, FiXedPosition.transform.position, MovementSpeed * Time.deltaTime);


        foreach (var item in DecalsUIs)
        {
            item.SetActive(false);
        }



        LeftCube.SetActive(false);



    }

}
