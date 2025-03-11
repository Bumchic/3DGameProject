using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateMachine
{
    public State CurrentState;
    public CharacterStateMachine(State currentState)
    {
        Initialize(currentState);
    }

    public void ChangeState(State NextState)
    {
        CurrentState.ExitState();
        CurrentState = NextState;
        CurrentState.EnterState();
    }

    public void Initialize(State StartingState)
    {
        CurrentState = StartingState;
        CurrentState.EnterState();
    }
}
