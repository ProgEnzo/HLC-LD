using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpZones : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private GameObject player;

    [SerializeField] private GameObject canvas;

    [SerializeField] private KeyCode tp = KeyCode.F;

    private void OnTriggerStay(Collider other)
    {
        canvas.SetActive(true);
        
        if (Input.GetKeyDown(tp))
        {
            player.transform.position = target.transform.position;
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
