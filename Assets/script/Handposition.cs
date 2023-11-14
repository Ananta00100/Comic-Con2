using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handposition : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Debug.Log("position  "+this.gameObject.transform.position.x+   "     y"+ this.gameObject.transform.position.y + "     z" + this.gameObject.transform.position.z);
    }
}
