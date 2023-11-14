using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;


public class Car5MaterealChange : MonoBehaviour
{

    [SerializeField] private GameObject[] CarModels;

    [SerializeField] private GameObject[] DecalProjecter;
    public int Num;
    public GameObject[] DecalMAtereal;
    public bool OnChangeSticker;


    public void Start()
    {
        OnChangeSticker = true;
    }
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            Num += 1;

          if (Num >2)
            {
            Num = 0;
            }
            //Create new material instance for the decal projector
        }
    }
    public void Game()
    {
        Debug.Log("dd");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (OnChangeSticker)
        {
            Debug.Log("Collision");
            Num += 1;
            switch (Num)
            {
                case 1:
                    DecalProjecter[0].SetActive(true);
                    DecalProjecter[1].SetActive(false);
                    DecalProjecter[2].SetActive(false);
                    DecalProjecter[3].SetActive(true);
                    DecalProjecter[4].SetActive(false);
                    DecalProjecter[5].SetActive(false);
                    break;
                case 2:
                    DecalProjecter[0].SetActive(false);
                    DecalProjecter[1].SetActive(true);
                    DecalProjecter[2].SetActive(false);
                    DecalProjecter[3].SetActive(false);
                    DecalProjecter[4].SetActive(true);
                    DecalProjecter[5].SetActive(false);
                    break;
                case 3:
                    DecalProjecter[0].SetActive(false);
                    DecalProjecter[1].SetActive(false);
                    DecalProjecter[2].SetActive(true);
                    DecalProjecter[3].SetActive(false);
                    DecalProjecter[4].SetActive(false);
                    DecalProjecter[5].SetActive(true);
                    break;
            }
        }
        if(Num>3)
        {
            Num = 0;
        }
    }
    public void ChangeMaterial()
    {
        Debug.Log("carName");
        Num += 1;
       /* for (int i = 0; i < CarModels.Length; i++)
        {
            CarModels[i].GetComponent<Renderer>().material = CarMetereals[Num];
        }*/
        StartCoroutine(ChangeMaterealwait());
        if (Num > 2)
        {
            Num = 0;
        }
    }
    IEnumerator ChangeMaterealwait()
    {
        yield return new WaitForSeconds(1);

    }
}
