
using Zenject;

public class StartSessionState : IBaseGameState
{
    private StateMachine _stateMachine;
    private FormationState _formationState;

    [Inject]
    public StartSessionState(StateMachine stateMachine, FormationState formationState)
    {
        _stateMachine = stateMachine;
        _formationState = formationState;
    }

    public void Enter()
    {
        _stateMachine.SetState(_formationState);
    }

    public void Exit()
    {
        
    }

    public void Update()
    {
        
    }
}
