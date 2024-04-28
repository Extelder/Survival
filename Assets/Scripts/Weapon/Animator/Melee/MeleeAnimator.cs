using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAnimator : WeaponAnimator
{
    [SerializeField] private PlayerInputs _playerInputs;

    private void Update()
    {
        if ((Mathf.Abs(_playerInputs.MoveAxisInput.InputAxis.x) != 0 ||
             Mathf.Abs(_playerInputs.MoveAxisInput.InputAxis.y) != 0) ||
            (Mathf.Abs(_playerInputs.MoveAxisInput.InputAxis.x) != 0 &&
             Mathf.Abs(_playerInputs.MoveAxisInput.InputAxis.y) != 0))
        {
            WalkAnimation();
        }
    }

    private void OnEnable()
    {
        _playerInputs.RunInput.RunButtonDown += RunAnimation;
        _playerInputs.AttackInput.AttackButtonDown += AttackAnimation;
    }

    private void OnDisable()
    {
        _playerInputs.RunInput.RunButtonDown -= RunAnimation;
        _playerInputs.AttackInput.AttackButtonDown -= AttackAnimation;
    }
}