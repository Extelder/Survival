using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallWeaponAnimationState : WeaponAnimationState
{
    public override void Enter()
    {
        CanChange = false;
        Animator.FallAnimation();
    }
}
