using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active2canvas : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject pluie;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(true);
            pluie.SetActive(true);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(false);
            pluie.SetActive(false);
        }
    }
}
