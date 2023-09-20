using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SessionManager : MonoBehaviour
{
    private StateMachine _stateMachine;
    private StartSessionState _startSessionState;

    [Inject]
    public void Construct(StateMachine stateMachine, StartSessionState startSessionState)
    {
        _stateMachine = stateMachine;
        _startSessionState = startSessionState;
    }

    void Start()
    {
        _stateMachine.SetState(_startSessionState);
    }

}
