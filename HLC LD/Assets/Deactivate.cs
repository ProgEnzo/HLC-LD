using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    [SerializeField] private GameObject barrieres;
    [SerializeField] private GameObject sot;
    [SerializeField] private GameObject canvas;

    [SerializeField] private KeyCode fin = KeyCode.F;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(true);

            if (Input.GetKeyDown(fin))
            {
                barrieres.SetActive(false);
                sot.SetActive(false);
            }
        }
    }
}
