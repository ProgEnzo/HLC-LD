using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorModifier : MonoBehaviour
{
    private Renderer rend;

    [SerializeField] private KeyCode changeColor = KeyCode.C;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ca detecte ?");
            if (Input.GetKeyDown(changeColor))
            {
                rend.material.color = new Color(236, 90, 90);
                Debug.Log("ca fonctionne ?");
            }
        }
    }
}
