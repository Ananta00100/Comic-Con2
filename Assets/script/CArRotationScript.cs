using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CArRotationScript : MonoBehaviour
{


    [SerializeField]
    public GameObject CarMobel;

    public float RotateSpeed;
    public float time;
    public Material Glowmetereal;

    public Transform from;
    public Transform to;
    public float Movespeed;
    public float RotationSpeed;
    private float timeCount = 0.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            CarMobel.transform.rotation = Quaternion.Slerp(Quaternion.identity, Quaternion.Euler(0, 180, 0), timeCount);
            timeCount = timeCount + Time.deltaTime;
        }
            CarMobel.transform.Rotate(0, -Movespeed * Time.deltaTime,0);

    }
}
