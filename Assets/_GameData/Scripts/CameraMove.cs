using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public CinemachineVirtualCamera camera;
    private CinemachineTrackedDolly dolly;
    void Start()
    {
        dolly = camera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    void Update()
    {
        dolly.m_PathPosition += 0.01f;
    }
}


