using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollider : MonoBehaviour
{
    public GameObject Newcar;
    public GameObject Decal;

    public Rigidbody Leftrigedbody;
    public int Num = 0;

    public GameObject Left;
    public bool sipe;

    private void Start()
    {
        sipe = true;
        Num = 0;
        Leftrigedbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
       
            Debug.Log("Right");
            switch (Num)
            {
                case 0:
                    Newcar.GetComponent<CarSelection>().Next();

                    break;
                case 1:
                    Decal.GetComponent<DecalsSelection>().Next();
                    break;
            
        }
        StartCoroutine(Deactive());
      
    }
    IEnumerator Deactive()
    {
        Left.SetActive(false);
    
      //  sipe = false;
        yield return new WaitForSeconds(1f);   
        Left.SetActive(true);
       //this.gameObject.SetActive(true);
        Debug.Log("deactiveleft");


    }



}
