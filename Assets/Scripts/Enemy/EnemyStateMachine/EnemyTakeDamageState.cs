using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTakeDamageState : State
{
    [SerializeField] private EnemyStateController _stateController;
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private EnemyAnimator _animator;

    private float _agentSpeed;

    private void Awake()
    {
        _agentSpeed = _agent.speed;
    }

    public override void Enter()
    {
        CanChange = false;
        _agent.speed = 0;
        _animator.TakeDamage();
    }

    public override void Exit()
    {
        _agent.speed = _agentSpeed;
    }

    public virtual void TakeDamageAnimationEnd()
    {
        CanChange = true;
        _stateController.Chase();
        Debug.Log(CanChange);
    }
}