using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CinemachineCameraFOV : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtualCamera;
    [SerializeField] private float _defaultFov;

    public void SetFOV(float value)
    {
        _cinemachineVirtualCamera.m_Lens.FieldOfView = value;
    }
}