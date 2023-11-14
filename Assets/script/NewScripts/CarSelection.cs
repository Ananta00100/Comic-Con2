using UnityEngine;

public class CarSelection : MonoBehaviour
{
    public static bool isCarSelected = false;

    public GameObject[] cars;

    private int currentIndex = 0;

    private void Update()
    {
        if (!isCarSelected)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Next();
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Previous();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                isCarSelected = true;
                DecalsSelection.onCarSelected?.Invoke();
            }
        }
    }

    public void Next()
    {
        cars[currentIndex].SetActive(false);

        if (currentIndex == cars.Length - 1) { currentIndex = 0; }
        else { currentIndex++; }

        cars[currentIndex].SetActive(true);
    }

    public void Previous()
    {
        cars[currentIndex].SetActive(false);

        if (currentIndex == 0) { currentIndex = cars.Length - 1; }
        else { currentIndex--; }

        cars[currentIndex].SetActive(true);
    }
}
