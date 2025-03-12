using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttribute : MonoBehaviour
{
    public CharacterStateMachine characterStateMachine { get; set; }
    public GroundedState groundedState { get; set; }
    [field: SerializeField] public Transform RespawnLocation { get; set; }
    public void Awake()
    {
        characterStateMachine = new CharacterStateMachine();
        groundedState = new GroundedState(characterStateMachine, this);
    }
    public void Update()
    {
        characterStateMachine.CurrentState.GameUpdate();
    }
    public void FixedUpdate()
    {
        characterStateMachine.CurrentState.FixUpdate();
    }
    public void Start()
    {
        characterStateMachine.Initialize(groundedState);
    }
}
