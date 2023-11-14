using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{


    [SerializeField]  int Num;

    public DemoScript Demo;


    private void Start()
    {
      Demo = GameObject.Find("Left").GetComponent<DemoScript>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(1);
    }

}
