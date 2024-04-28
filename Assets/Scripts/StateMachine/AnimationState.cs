using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAnimationState : State
{
    [field: SerializeField] public WeaponAnimator Animator;

    public override void Exit()
    {
        Animator.IdleAnimation();
    }
}
