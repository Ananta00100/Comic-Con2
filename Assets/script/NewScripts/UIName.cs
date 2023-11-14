using UnityEngine;

public class UIName : MonoBehaviour
{
    public static string username;

    public TMPro.TMP_InputField nameInp;
    public GameObject canvas;
    public GameObject cars;

    public void OnClickNext() {
        username = nameInp.text;

        canvas.SetActive(false);
        cars.SetActive(true);
    }
}
