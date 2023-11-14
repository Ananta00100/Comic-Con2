using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ChooseCar : MonoBehaviour
{

    public Material[] decalmatereals;
    public GameObject[] DecalProjecter;


    public int Num;



    private void OnCollisionEnter(Collision collision)
    {
        Num += 1;


        Debug.Log("ChangeDacl");
        switch(Num)
        {
               case 1:
                DecalProjecter[0].SetActive(true);
                DecalProjecter[1].SetActive(false);
                DecalProjecter[2].SetActive(false);
                DecalProjecter[3].SetActive(false);
                DecalProjecter[4].SetActive(false);
                DecalProjecter[5].SetActive(false);
                break;
                case 2:
                DecalProjecter[0].SetActive(false);
                DecalProjecter[1].SetActive(true);
                DecalProjecter[2].SetActive(false);
                DecalProjecter[3].SetActive(false);
                DecalProjecter[4].SetActive(false);
                DecalProjecter[5].SetActive(false);
                break;
                case 3:
                DecalProjecter[0].SetActive(false);
                DecalProjecter[1].SetActive(false);
                DecalProjecter[2].SetActive(true);
                DecalProjecter[3].SetActive(false);
                DecalProjecter[4].SetActive(false);
                DecalProjecter[5].SetActive(false);
                break;
                case 4:
                DecalProjecter[0].SetActive(false);
                DecalProjecter[1].SetActive(false);
                DecalProjecter[2].SetActive(false);
                DecalProjecter[3].SetActive(true);
                DecalProjecter[4].SetActive(false);
                DecalProjecter[5].SetActive(false);
                break;
                case 5:
                DecalProjecter[0].SetActive(false);
                DecalProjecter[1].SetActive(false);
                DecalProjecter[2].SetActive(false);
                DecalProjecter[3].SetActive(false);
                DecalProjecter[4].SetActive(true);
                DecalProjecter[5].SetActive(false);
                break;
                case 6:
                DecalProjecter[0].SetActive(false);
                DecalProjecter[1].SetActive(false);
                DecalProjecter[2].SetActive(false);
                DecalProjecter[3].SetActive(false);
                DecalProjecter[4].SetActive(false);
                DecalProjecter[5].SetActive(true);
                break;
        }
        if(Num>6)
        {
            Num = 0;
        }

    }
}
