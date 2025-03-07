using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStateMachineAbstract
{
    public State CurrentState;
    public void ChangeState(State NextState)
    {

    }

    public void Initialize(State StartingState)
    {
        
    }
}

