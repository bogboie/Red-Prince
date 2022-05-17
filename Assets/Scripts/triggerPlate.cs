using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPlate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plate"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
