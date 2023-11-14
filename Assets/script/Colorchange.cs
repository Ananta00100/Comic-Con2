using System.Collections;
using System.Collections.Generic;
using TouchScript.Behaviors.Cursors;

using UnityEditor;
using UnityEngine;

public class Colorchange : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject CarGameObj;
    public Camera Maincamara;
    public Transform Backettransform;
    public bool PalmClose;
    Vector3 CarRotateAmount;
    private void Update()
    {
        //   CarRotateAmount  = Maincamara.ScreenPointToRay(Input.mousePosition.);

        //  Debug.Log(Backettransform.position.x);
        /*  Vector3 Mouseposition= Input.mousePosition;
              Debug.Log("x"+Mouseposition.x);
              Debug.Log("y" + Mouseposition.y);*/
        /*    if (Backettransform.position.x < 0)
            {
             CarGameObj.transform.Rotate(0, 50 * Time.deltaTime, 0);
                Debug.Log("rotate-x");
                //  CarGameObj.transform.Rotate(2*Time.deltaTime,0,0);
            }
            if (Backettransform.position.x > 0)
                CarGameObj.transform.Rotate(0, -50 * Time.deltaTime, 0);
            Debug.Log("rotatex");*/

        // CarGameObj.transform.Rotate(-2*Time.deltaTime, 0, 0);

        if (Input.GetMouseButton(1))
        {
            Vector3 Mouseposition = Input.mousePosition;
            if (Mouseposition.y < 500)
            { CarGameObj.transform.Rotate(10 * Time.deltaTime, 0, 0); }
            if (Mouseposition.y > 500)
            { CarGameObj.transform.Rotate(-10 * Time.deltaTime, 0, 0); }
        }
}
    public void OnPalmClose()
    {
     PalmClose = true;

    } 
    }










