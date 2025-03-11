using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttribute : MonoBehaviour
{
    public CharacterStateMachine characterStateMachine { get; set; }
    public GroundedState groundedState { get; set; }
    public void Awake()
    {
        characterStateMachine = new CharacterStateMachine(groundedState);
        groundedState = new GroundedState(characterStateMachine, this);
    }
    public void Update()
    {
        
    }
    public void Start()
    {
        
    }
}
