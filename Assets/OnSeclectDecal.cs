using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSeclectDecal : MonoBehaviour
{

    public GameObject CarModel;
    public Animator CArAnimator;





    private void OnCollisionEnter(Collision collision)
    {
        CArAnimator.SetTrigger("OnClick");
    }




}
