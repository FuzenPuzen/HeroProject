
using Zenject;

public class StartSessionState : IBaseGameState
{
    private FormationState _formationState;
    private HeroUnitSquadService _heroUnitSquadService;
    private EnemyUnitSquadService _enemyUnitSquadService;
    private StateMachine _stateMachine;
    private BattleState _battleState;

    [Inject]
    public StartSessionState
        (
        HeroUnitSquadService heroUnitSquadService,
        StateMachine stateMachine,
        BattleState battleState,
        EnemyUnitSquadService enemyUnitSquadService)
    {
        _heroUnitSquadService = heroUnitSquadService;
        _enemyUnitSquadService = enemyUnitSquadService;
        _battleState = battleState;
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
