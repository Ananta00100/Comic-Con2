using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CArMaterealChange : MonoBehaviour
{

    [SerializeField] private GameObject[] CarModels;
    public Material[] CarMetereals;

    public int Num;

    public void Game()
    {
        Debug.Log("dd");
    }
    public void ChangeMaterial()
    {
        Debug.Log("carName");
        Num += 1;
        for (int i = 0; i < CarModels.Length; i++)
        {
         StartCoroutine(ChangeMatereal());
        }
        if (Num > 2)
        {
            Num = 0;
        }
    }
    IEnumerator ChangeMatereal()
    {
        yield return new WaitForSeconds(0.3f);
        for (int i = 0; i < CarModels.Length; i++)
        {
       CarModels[i].GetComponent<Renderer>().material = CarMetereals[Num];
        }

        
    }

}
