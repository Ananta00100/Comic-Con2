using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemocarRotation : MonoBehaviour
{

    [SerializeField] public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 10* Time.deltaTime, 0);
        
    }
}
