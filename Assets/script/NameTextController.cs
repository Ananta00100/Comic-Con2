using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameTextController : MonoBehaviour
{
    public string PlayerName;
    public GameObject Canvas;
    

    public void ReadStringInput()
    {
        PlayerName = Canvas.GetComponent<TMP_InputField>().text;
        Debug.Log(PlayerName );

        StaticNamecontroller.PlayerName= Canvas.GetComponent<TMP_InputField>().text;
          Canvas.SetActive(false);

    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.N)) 
        {

            Debug.Log(PlayerName);
            
        }
    }



}
