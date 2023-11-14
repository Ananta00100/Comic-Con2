using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Capsuleposition : MonoBehaviour
{

    public TMP_Text playernameonthecarName;

    public string PlayerName;
   public void PalyerName(string Name)
    {
        PlayerName = Name;

        Debug.Log("Playername"+PlayerName);
    }
}
