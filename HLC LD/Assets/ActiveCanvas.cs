using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCanvas : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(true);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(false);
        }
    }
}
