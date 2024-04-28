using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimationState : WeaponAnimationState
{
    public override void Enter()
    {
        CanChange = false;
        Animator.AttackAnimation();
    }


    public void AttackAnimationEnd()
    {
        CanChange = true;
    }
}