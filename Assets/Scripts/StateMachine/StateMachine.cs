using System;
using System.Collections;
using System.Collections.Generic;
using KrisDevelopment.EnvSpawn;
using UnityEngine;

public class StateMachine
{
    public State CurrentState { get; private set; }

    public StateMachine(State state)
    {
        Initial(state);
    }

    public void ChangeState(State state)
    {
        if (CurrentState.CanChange && CurrentState != state)
        {
            CurrentState.Exit();
            CurrentState = state;
            CurrentState.Enter();
        }
    }

    public void Initial(State startState)
    {
        CurrentState = startState;
        CurrentState.Enter();
    }
}