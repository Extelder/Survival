using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class WeaponAnimator : MonoBehaviour
{
    [field: SerializeField] public AnimatorController DefaultAnimator { get; private set; }
    [field: SerializeField] public AnimatorController AimingAnimator { get; private set; }
    [field: SerializeField] public Animator CurrentAnimator { get; private set; }

    public void SetAimingAnimator()
    {
        ChangeAnimator(AimingAnimator);
    }

    public void SetDefaultAnimator()
    {
        ChangeAnimator(DefaultAnimator);
    }

    public void IdleAnimation()
    {
        DisableAllAnimations();
    }

    public void WalkAnimation()
    {
        SetAnimationBool("IsWalking", true);
    }

    public void FallAnimation()
    {
        SetAnimationBool("IsFalling", true);
    }

    public void RunAnimation()
    {
        SetAnimationBool("IsRunning", true);
    }

    public void AttackAnimation()
    {
        SetAnimationBool("IsAttacking", true);
    }

    public virtual void SetAnimationBool(string name, bool value)
    {
        DisableAllAnimations();
        CurrentAnimator.SetBool(name, value);
    }

    public virtual void DisableAllAnimations()
    {
        CurrentAnimator.SetBool("IsRunning", false);
        CurrentAnimator.SetBool("IsWalking", false);
        CurrentAnimator.SetBool("IsAttacking", false);
    }

    private void ChangeAnimator(AnimatorController animator)
    {
        bool walkBool = CurrentAnimator.GetBool("IsWalking");
        bool runBool = CurrentAnimator.GetBool("IsRunning");
        bool attackBool = CurrentAnimator.GetBool("IsAttacking");
        CurrentAnimator.runtimeAnimatorController = animator;
        CurrentAnimator.SetBool("IsWalking", walkBool);
        CurrentAnimator.SetBool("IsRunning", runBool);
        CurrentAnimator.SetBool("IsAttacking", attackBool);
    }
}