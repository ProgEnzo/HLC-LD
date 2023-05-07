using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HotAndColdElements : MonoBehaviour
{
    [SerializeField] private GameObject chaud;
    [SerializeField] private GameObject froid;
    [SerializeField] private GameObject nuages;
    [SerializeField] private GameObject multiPrise;
    [SerializeField] private GameObject pluie;

    [SerializeField] private KeyCode chaudInput = KeyCode.A;
    [SerializeField] private KeyCode froidInput = KeyCode.E;
    [SerializeField] private KeyCode nuagesInput = KeyCode.Keypad1;
    [SerializeField] private KeyCode multiPriseInput = KeyCode.Keypad2;
    [SerializeField] private KeyCode finInput = KeyCode.Keypad3;


    private void Update()
    {
        SwitchChaudFroid();
        Puzzle1Resolu();
        Puzzle2Resolu();
        Fin();
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

    private void Puzzle1Resolu()
    {
        if (Input.GetKey(nuagesInput))
        {
            nuages.SetActive(true);
        }
    }

    private void Puzzle2Resolu()
    {
        if (Input.GetKey(multiPriseInput))
        {
            multiPrise.SetActive(true);
        }
    }

    private void Fin() //Lancer VFX de pluie et lancer écran de fin
    {
        if (Input.GetKey(finInput))
        {
            pluie.SetActive(true);
        }
    }
}
