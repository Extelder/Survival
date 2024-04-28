using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class EnemyStateController : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private EnemyAttackZone _attackZone;
    [SerializeField] private State _runState;
    [SerializeField] private State _attackState;
    [SerializeField] private State _takeDamageState;
 
    private StateMachine _machine;
    private CompositeDisposable _disposable = new CompositeDisposable();

    private void Awake()
    {
        _machine = new StateMachine(_runState);
    }

    private void OnEnable()
    {
        _health.OnCurrentHealthValueChaneged += OnHealthValueChanged;
        EnablePlayerDetect();
    }


    private void OnDisable()
    {
        _health.OnCurrentHealthValueChaneged -= OnHealthValueChanged;
        DisablePlayerDetect();
    }

    private void OnHealthValueChanged(float value)
    {
        if(value > 0)
            TakeDamage();
    }

    public void Chase()
    {
        _machine.ChangeState(_runState);
    }

    public void Attack()
    {
        _machine.ChangeState(_attackState);
    }

    public void TakeDamage()
    {
        _machine.ChangeState(_takeDamageState);
    }

    public virtual void EnablePlayerDetect()
    {
        Observable.EveryUpdate().Subscribe(_ =>
        {
            if (_attackZone.Detected.Value)
            {
                Attack();
                return;
            }

            Chase();
        }).AddTo(_disposable);
    }

    public virtual void DisablePlayerDetect()
    {
        _disposable.Clear();
    }
}