using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraEnculé : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera tpsCam;
    [SerializeField] private CinemachineVirtualCamera topCam;

    private bool isSwitched = false;

    public void OnEnable()
    {
        CmCameraSwitcher.Register(tpsCam);
        CmCameraSwitcher.Register(topCam);
    }

    public void OnDisable()
    {
        CmCameraSwitcher.Unregister(tpsCam);
        CmCameraSwitcher.Unregister(topCam);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Switch();
        }
    }

    private void Switch()
    {
        if (isSwitched)
        {
            Debug.Log("Oui");
            tpsCam.Priority = 0;
            topCam.Priority = 1;
        }
        else
        {
            Debug.Log("Non");
            tpsCam.Priority = 1;
            topCam.Priority = 0;
        }

        isSwitched = !isSwitched;
    }
}
