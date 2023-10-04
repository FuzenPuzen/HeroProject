using Zenject;

public class StartSessionState : IBaseGameState
{
    private FormationState _formationState;
    private HeroUnitSquadService _heroUnitSquadService;
    private EnemyUnitSquadService _enemyUnitSquadService;
    private StateMachine _stateMachine;

    [Inject]
    public StartSessionState
    (
        HeroUnitSquadService heroUnitSquadService,
        StateMachine stateMachine,
        FormationState formationState,
        EnemyUnitSquadService enemyUnitSquadService
    )
    {
        _heroUnitSquadService = heroUnitSquadService;
        _enemyUnitSquadService = enemyUnitSquadService;
        _formationState = formationState;
        _stateMachine = stateMachine;
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
