using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameController : MonoBehaviour
{

    public TMP_Text PlayerText;

    private void Start()
    {
        PlayerText.text = StaticNamecontroller.PlayerName;
    }


    public void Update()
    {

        if(Input.GetKeyUp(KeyCode.N)) 
        {

            Debug.Log(PlayerText.text);
        
        
        }
        
    }




}
