using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMotionCapture : MonoBehaviour
{

   public GameObject Cube;

    public GameObject CarBody;
    public int MovementSpeed;
    public GameObject LeftCube;


    // Update is called once per frame
    void Update()
    {
        if (Cube.transform.position.x < 0)
        {
            CarBody.transform.Rotate(0, MovementSpeed * Time.deltaTime, 0);

        }
        if (Cube.transform.position.x > 0)
        {
          
            CarBody.transform.Rotate(0, -MovementSpeed*Time.deltaTime, 0);


          
        }
    }
}
