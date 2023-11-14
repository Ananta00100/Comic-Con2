using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoScript : MonoBehaviour
{

    private static DemoScript _instance;

    public static DemoScript Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject HighScoreBord = GameObject.Find("Left");
                _instance = HighScoreBord.GetComponent<DemoScript>();
            }
            return _instance;
        }
    }
    public GameObject[] carPreFabs;
    public Scene[] AllCarScenes;
    public GameObject[] Materials;
    public GameObject FristPoint;
    public GameObject secoundPoint;


    public bool ChooseTheCAr;
    public GameObject CarModel;
    public int num = 0;

    public static DemoScript instance;  

    /*    public void Update() {
            Debug.Log(num);
            if (Input.GetKeyDown(KeyCode.W))
            {
                SceneManager.LoadScene(2);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(3);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(4);
            }
        }*/


    public void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(ChangetheCarModel());
        num += 1;
        if (num > 9)
        {
            num = 0;
        }

        Change();

    }




    public void Change()
    {
        foreach (var item in carPreFabs)
        {
            item.SetActive(false);
        }
        carPreFabs[num].SetActive(true);

        Debug.Log("change");

    }

    IEnumerator ChangetheCarModel() {

        yield return new WaitForSeconds(0.5f);
    }
    public void Cahngethecar()
    {
        StartCoroutine(ChangetheScene());
    }
    IEnumerator ChangetheScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(num);
    }
 /*   private void LateUpdate()
    {
        foreach (var item in carPreFabs)
        {
            item.SetActive(false);
        }
        carPreFabs[num].SetActive(true);
    }*/


 
}
