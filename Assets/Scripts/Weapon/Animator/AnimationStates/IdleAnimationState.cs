using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAnimationState : WeaponAnimationState
{
    public override void Enter()
    {
        Animator.IdleAnimation();
    }
}
