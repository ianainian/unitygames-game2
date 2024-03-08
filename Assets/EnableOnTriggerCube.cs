using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnTriggerCube : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject[] objectsToEnable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (objectToDisable != null)
            {
                objectToDisable.SetActive(false);
            }

            foreach (GameObject obj in objectsToEnable)
            {
                obj.SetActive(true);
            }
        }
    }
}
