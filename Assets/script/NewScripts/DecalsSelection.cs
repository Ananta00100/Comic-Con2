using System;
using TMPro;
using UnityEngine;

public class DecalsSelection : MonoBehaviour
{
    public static Action onCarSelected;

    public GameObject[] decals = new GameObject[3];

    private int currentIndex = 0;

    public TextMeshPro[] username;

    private void OnEnable()
    {
        onCarSelected += OnCarSelected;
        decals[0].SetActive(CarSelection.isCarSelected);
        foreach (TextMeshPro txt in username) { 
            txt.text = UIName.username;
        }
    }

    private void OnDisable()
    {
        onCarSelected -= OnCarSelected;
    }

    private void Update()
    {
        if (CarSelection.isCarSelected)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Next();
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Previous();
            }
        }
    }

    private void OnCarSelected() {
        decals[0].SetActive(true);
        foreach (TextMeshPro txt in username)
        {
            txt.text = UIName.username;
        }
    }

    public void Next() {
        decals[currentIndex].SetActive(false);

        if (currentIndex == decals.Length-1) { currentIndex = 0; }
        else { currentIndex++; }

        decals[currentIndex].SetActive(true);
    }

    public void Previous()
    {
        decals[currentIndex].SetActive(false);

        if (currentIndex == 0) { currentIndex = decals.Length-1; }
        else { currentIndex--; }

        decals[currentIndex].SetActive(true);
    }
}
