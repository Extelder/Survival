using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttackState : State
{
    [SerializeField] private bool _attackCanBreak;
    [SerializeField] private float _damage;
    [SerializeField] private Health _health;
    [SerializeField] private EnemyAnimator _animator;
    [SerializeField] private NavMeshAgent _agent;

    private float _agentSpeed;

    private void Awake()
    {
        _agentSpeed = _agent.speed;
    }

    public override void Enter()
    {
        if (!_attackCanBreak)
            CanChange = false;
        _agent.speed = 0f;
        _animator.Attack();
    }

    public override void Exit()
    {
        _agent.speed = _agentSpeed;
    }

    public virtual void AttackAnimationEnd()
    {
        CanChange = true;
        Debug.Log(CanChange);
    }

    public virtual void Attack()
    {
        _health.TakeDamage(_damage);
    }
}