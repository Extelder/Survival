using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RaycastWeaponAttack : Raycaster
{
    [SerializeField] private int _attacksCount = 1;
    [SerializeField] private float _damage;
    [SerializeField] private float _spreadMultiply;

    public Ray Raycast { get; private set; }
    public RaycastHit Hit { get; private set; }
    public event Action Attacked;
    public event Action BoxHitted;
    public bool HaveSpread = true;

    public virtual void Attack()
    {
        for (int i = 0; i < _attacksCount; i++)
        {
            if (HaveSpread)
            {
                Raycast = ThrowRaycast(out RaycastHit hit,
                    transform.rotation * (Random.insideUnitCircle / _spreadMultiply));
                Hit = hit;
            }
            else
            {
                Raycast = ThrowRaycast(out RaycastHit hit,
                    transform.rotation * new Vector3(0, 0, 0));
                Hit = hit;
            }
            Attacked?.Invoke();

            if (Hit.collider != null && Hit.collider.TryGetComponent<HitBox>(out HitBox hitBox))
            {
                hitBox.Hit(_damage, Hit);
                BoxHitted?.Invoke();
            }
        }
    }

    public virtual float GetDamage()
    {
        return _damage;
    }

    public virtual void OnBoxHitted(HitBox hitBox)
    {
        hitBox.Hit(GetDamage());
    }
}