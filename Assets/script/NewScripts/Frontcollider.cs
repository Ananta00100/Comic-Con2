using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frontcollider : MonoBehaviour
{

    public GameObject left;
    public GameObject right;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        left.GetComponent<LeftCollider>().Num = 1;
        right.GetComponent<RightCollider>().Num = 1;
        this.gameObject.SetActive(false);

    }

}
