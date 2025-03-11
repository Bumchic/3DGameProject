using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedState :State, GroundStateInterface
{
    public GroundedState(CharacterStateMachine characterStateMachine, CharacterAttribute character) : base(characterStateMachine, character)
    {

    }

    public override void EnterState()
    {
        base.EnterState();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FixUpdate()
    {
        base.FixUpdate();
    }

    public override void GameUpdate()
    {
        base.GameUpdate();
    }

    public void GroundMovement()
    {
        throw new System.NotImplementedException();
    }

    public void Jump()
    {
        throw new System.NotImplementedException();
    }

    public void PullRope()
    {
        throw new System.NotImplementedException();
    }

    public void ShootRope()
    {
        throw new System.NotImplementedException();
    }
}
