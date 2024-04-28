using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimationState :WeaponAnimationState
{
    public override void Enter()
    {
        Animator.WalkAnimation();
    }
   
}
