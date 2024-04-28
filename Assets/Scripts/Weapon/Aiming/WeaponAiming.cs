using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAiming : MonoBehaviour
{
    [SerializeField] private WeaponAnimator _weaponAnimator;
    [SerializeField] private PlayerInputs _inputs;

    private void OnEnable()
    {
        _inputs.AimingInput.AimButtonDown += Aiming;
        _inputs.AimingInput.AimButtonUp += StopAiming;
    }

    private void OnDisable()
    {
        _inputs.AimingInput.AimButtonDown -= Aiming;
        _inputs.AimingInput.AimButtonUp -= StopAiming;
    }

    private void Aiming()
    {
        _weaponAnimator.SetAimingAnimator();
    }

    private void StopAiming()
    {
        _weaponAnimator.SetDefaultAnimator();
    }
}