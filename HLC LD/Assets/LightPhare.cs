using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPhare : MonoBehaviour
{
    [SerializeField] private GameObject light;
    [SerializeField] private GameObject canvas;
    [SerializeField] private KeyCode allumer = KeyCode.F;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(true);

            if (Input.GetKeyDown(allumer))
            {
                light.SetActive(true);
            }
        }
    }
}
