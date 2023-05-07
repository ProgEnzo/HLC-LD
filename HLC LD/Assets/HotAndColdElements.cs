using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HotAndColdElements : MonoBehaviour
{
    [SerializeField] private GameObject chaud;
    [SerializeField] private GameObject froid;

    [SerializeField] private KeyCode chaudInput = KeyCode.A;
    [SerializeField] private KeyCode froidInput = KeyCode.E;


    private void Update()
    {
        SwitchChaudFroid();
    }

    private void SwitchChaudFroid()
    {
        if (Input.GetKeyDown(chaudInput))
        {
            chaud.SetActive(true);
            froid.SetActive(false);
        }
        else if (Input.GetKeyDown(froidInput))
        {
            chaud.SetActive(false);
            froid.SetActive(true);
        }
    }
}
