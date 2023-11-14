using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    public GameObject CannonPrefb;
    public int RotationSpeed;
    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {   
               CannonPrefb.transform.rotation = Quaternion.Euler(5*Time.deltaTime,RotationSpeed*Time.deltaTime, 0f);
                Debug.Log("Rotate");
        }

       if(Input.GetKeyDown(KeyCode.V))
        {
            CannonPrefb.transform.rotation = Quaternion.Euler(7 * Time.deltaTime, RotationSpeed * Time.deltaTime, 6f);
            Debug.Log("Rotate");
        }
    }
}
