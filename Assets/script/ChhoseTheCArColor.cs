using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChhoseTheCArColor : MonoBehaviour
{
    [SerializeField] private GameObject[] Carmodel;

    // [Header"model")]

    public Renderer CarModelMetereal;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            for (int i = 0; i < Carmodel.Length; i++)
            {
              //  CarModelMetereal = Carmodel[i].GetComponent<Renderer>();
               // CarModelMetereal.material.SetColor("_Color", Color.black);
               // Debug.Log("ChangeTheColor");



            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            for (int i = 0; i < Carmodel.Length; i++)
            {
                CarModelMetereal = Carmodel[i].GetComponent<Renderer>();
                CarModelMetereal.material.SetColor("_Color", Color.green);
                Debug.Log("ChangeTheColor");
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < Carmodel.Length; i++)
            {
                CarModelMetereal = Carmodel[i].GetComponent<Renderer>();
                CarModelMetereal.material.SetColor("_Color", Color.red);
                Debug.Log("ChangeTheColor");
            }
        }
        /*   if (Input.GetKeyDown(KeyCode.W))
           {
               Carmodel.GetComponent<Material>().color = Color.white;

           }*/

    }
}
