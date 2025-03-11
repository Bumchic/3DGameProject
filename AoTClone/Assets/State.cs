using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    protected CharacterAttribute character;
    protected CharacterStateMachine characterStateMachine;
    public State(CharacterStateMachine characterStateMachine, CharacterAttribute character)
    {
        this.characterStateMachine = characterStateMachine;
        this.character = character;
    }
    public virtual void EnterState()
    {
        
    }
    public virtual void ExitState()
    {

    }
    public virtual void GameUpdate()
    {

    }
    public virtual void FixUpdate()
    {

    }
}
