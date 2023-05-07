using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlateformes : MonoBehaviour
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
        
        if (!isMoving) //Jacques a dit que j'ai du nesting
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
                MaLaBa(targetDown);
            }
            else
            {
                target = targetTop;
                MaLaBa(targetTop);
            }

            if (Vector3.Distance(target.position, transform.position) <= 0.5f)
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
    
    private void MaLaBa(Transform target)
    {
        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
        //transform.position = Vector3.Lerp(transform.position, targetTop.position, speed * Time.deltaTime);
    }

    /*private void Descente()
    {
        Vector3 direction = (targetDown.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
        //transform.position = Vector3.Lerp(transform.position, targetDown.position, speedForPortail * Time.deltaTime);
    }*/
}
