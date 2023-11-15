using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCollider : MonoBehaviour
{


    public GameObject carGameobj;
    public GameObject Decal;
    public GameObject right;

    public bool Sipe;

    public int Num = 0;

    private void Start()
    {
        Num = 0;
        Sipe = true;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("left");

       

            switch (Num)
            {
                case 0:
                    carGameobj.GetComponent<CarSelection>().Previous();
                    break;
                case 1:
                    Decal.GetComponent<DecalsSelection>().Previous();
                    break;
            }
            StartCoroutine(Deactive());
    }

    IEnumerator Deactive()
    {
        right.SetActive(false);
     // Sipe = false;
        yield return new WaitForSeconds(0.7f);
       // Sipe=true;
        right.SetActive(true);
       // this.gameObject.SetActive(true);
        Debug.Log("deactiveright");
    }



}
