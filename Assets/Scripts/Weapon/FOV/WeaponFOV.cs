using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFOV : MonoBehaviour
{
    [SerializeField] private CinemachineCameraFOV _cinemachineCameraFov;
    [SerializeField] private PlayerInputs _inputs;

    [field: SerializeField] public float AimFOV { get; private set; }
    [field: SerializeField] public float DefaultFOV { get; private set; }

    private void OnEnable()
    {
        _inputs.AimingInput.AimButtonDown += SetAimingFOV;
        _inputs.AimingInput.AimButtonUp += SetDefaultFOV;
    }

    private void OnDisable()
    {
        _inputs.AimingInput.AimButtonDown -= SetAimingFOV;
        _inputs.AimingInput.AimButtonUp -= SetDefaultFOV;
    }


    private void SetAimingFOV()
    {
        _cinemachineCameraFov.SetFOV(AimFOV);
    }

    private void SetDefaultFOV()
    {
        _cinemachineCameraFov.SetFOV(DefaultFOV);
    }
}