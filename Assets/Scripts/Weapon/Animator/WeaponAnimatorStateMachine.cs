using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class WeaponAnimatorStateMachine : MonoBehaviour
{
    [SerializeField] private State _walkAnimationState;
    [SerializeField] private State _runAnimationState;
    [SerializeField] private State _idleAnimationState;
    [SerializeField] private State _attackAnimationState;

    [SerializeField] private PlayerInputs _playerInputs;

    private StateMachine _stateMachine;
    private bool _running;
    private CompositeDisposable _disposable = new CompositeDisposable();

    private void Start()
    {
        _stateMachine = new StateMachine(_idleAnimationState);
    }

    private void Update()
    {
        if ((Mathf.Abs(_playerInputs.MoveAxisInput.InputAxis.x) != 0 ||
             Mathf.Abs(_playerInputs.MoveAxisInput.InputAxis.y) != 0) ||
            (Mathf.Abs(_playerInputs.MoveAxisInput.InputAxis.x) != 0 &&
             Mathf.Abs(_playerInputs.MoveAxisInput.InputAxis.y) != 0))
        {
            if (_running)
            {
                RunAnimationState();
                return;
            }

            WalkAnimationState();
        }
        else
        {
            IdleAnimationState();
        }
    }

    private void OnEnable()
    {
        _playerInputs.AttackInput.AttackButtonDown += AttackAnimationState;
        _playerInputs.RunInput.RunButtonDown += RunningAnimation;
        _playerInputs.RunInput.RunButtonUp += StopRunningAnimation;
    }

    private void OnDisable()
    {
        _playerInputs.AttackInput.AttackButtonDown -= AttackAnimationState;
        _playerInputs.RunInput.RunButtonDown -= RunningAnimation;
        _playerInputs.RunInput.RunButtonUp -= StopRunningAnimation;
    }

    public void WalkAnimationState()
    {
        _stateMachine.ChangeState(_walkAnimationState);
    }

    public void RunningAnimation()
    {
        _running = true;
    }

    public void StopRunningAnimation()
    {
        _running = false;
    }

    public void RunAnimationState()
    {
        _stateMachine.ChangeState(_runAnimationState);
    }

    public void AttackAnimationState()
    {
        _stateMachine.ChangeState(_attackAnimationState);
    }

    public void IdleAnimationState()
    {
        _stateMachine.ChangeState(_idleAnimationState);
    }
}