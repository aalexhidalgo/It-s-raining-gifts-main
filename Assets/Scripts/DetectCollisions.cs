using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private int counter = 0;
    
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Present"))
        {
            counter += 1;
            Debug.Log($"Llevas {counter} regalos recogidos");
            Destroy(otherCollider.gameObject);
        }
    }
}
