using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PlayerGround : MonoBehaviour
{
    public ReactiveProperty<bool> OnGround { get; private set; } = new ReactiveProperty<bool>(false);

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent<Ground>(out Ground ground))
        {
            OnGround.Value = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Ground>(out Ground ground))
            OnGround.Value = false;
    }
}