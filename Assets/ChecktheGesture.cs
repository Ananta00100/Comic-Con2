using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecktheGesture : MonoBehaviour
{
    public Transform referencePoint; // Set this in the inspector to the reference point
    public GameObject targetObject;  // Set this in the inspector to the GameObject you want to check

    void Update()
    {
        if (targetObject != null && referencePoint != null)
        {
            // Get the middle point of the targetObject
            Vector3 middlePoint = targetObject.transform.position;

            // Calculate the direction from the reference point to the middle point
            Vector3 direction = middlePoint - referencePoint.position;

            // Check if the middle point is to the left or right of the reference point
            if (Vector3.Dot(direction, referencePoint.right) > 0)
            {
                // Right Gesture
                Debug.Log("Right Gesture");
            }
            else
            {
                // Left Gesture
                Debug.Log("Left Gesture");
            }
        }
        else
        {
            Debug.LogWarning("Reference point or target object not assigned!");
        }
    }
}


