using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopAttackInput : MonoBehaviour, IAttackInput
{
    [SerializeField] private KeyCode _key;

    public event Action AttackButtonDown;
    public event Action AttackButtonUp;

    private void Update()
    {
        if (Input.GetKeyUp(_key))
        {
            AttackButtonUp?.Invoke();
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(_key))
        {
            AttackButtonDown?.Invoke();
        }
    }
}