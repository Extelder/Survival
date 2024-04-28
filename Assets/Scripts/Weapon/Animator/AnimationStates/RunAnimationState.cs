using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnimationState : WeaponAnimationState
{
   public override void Enter()
   {
      Animator.RunAnimation();
   }

   
}
