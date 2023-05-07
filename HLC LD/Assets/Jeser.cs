using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeser : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private float speed;
    [SerializeField] private float speedForPortail;
    
    [SerializeField] private Transform targetTop;
    [SerializeField] private Transform targetDown;

    [SerializeField] private bool isMoving;
    [SerializeField] private bool isOnBoard;
    [SerializeField] private bool isOnTop;
    
    private void Update()
    {
        if (!isOnBoard)
            return;
        
        if (!isMoving)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                isMoving = true;
            }
        }
        else
        {
            Transform target;
                
            if (isOnTop)
            {
                target = targetDown;
                Descente();
            }
            else
            {
                target = targetTop;
                Ascension();
            }

            if ((target.position - transform.position).magnitude <= 0.5f)
            {
                isMoving = false;
                isOnTop = !isOnTop;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = this.transform;
            canvas.SetActive(true);
            isOnBoard = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = null;
            canvas.SetActive(false);
            isOnBoard = false;
        }
    }

    private void Ascension()
    {
        transform.position = Vector3.Lerp(transform.position, targetTop.position, speed * Time.deltaTime);
    }

    private void Descente()
    {
        transform.position = Vector3.Lerp(transform.position, targetDown.position, speedForPortail * Time.deltaTime);
    }
}
