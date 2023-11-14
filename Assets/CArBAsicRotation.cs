using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CArBAsicRotation : MonoBehaviour
{
    public GameObject CArModel;
  public int MovementSpeed;

    public GameObject Cube;
    // Update is called once per fram

    void Update()
    {
        Debug.Log("Rotate");

      //  Debug.Log(Cube.transform.position.x);


       CArModel.transform.Rotate(0,0, MovementSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Rotate");
    }



}
