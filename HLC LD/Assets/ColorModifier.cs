using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorModifier : MonoBehaviour
{
    private Renderer rend;

    [SerializeField] private KeyCode changeColor = KeyCode.C;
    [SerializeField] private GameObject canvas;
    

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(true);
            
            Debug.Log("ca detecte ?");
            if (Input.GetKeyDown(changeColor))
            {
                rend.material.color = Color.red;
                Debug.Log("ca fonctionne ?");
            }
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
