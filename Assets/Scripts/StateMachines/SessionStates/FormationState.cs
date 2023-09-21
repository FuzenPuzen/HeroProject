
using Zenject;

public class FormationState : IBaseGameState
{
    private HeroUnitSquadService _heroUnitSquadService;
    private EnemyUnitSquadService _enemyUnitSquadService;
    private StateMachine _stateMachine;
    private BattleState _battleState;

    [Inject]
    public FormationState
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
        _heroUnitSquadService.EnterFormationState();
        _enemyUnitSquadService.EnterFormationState();
        _stateMachine.SetState(_battleState);

    }

    public void Exit()
    {
        _heroUnitSquadService.Exit();
        _enemyUnitSquadService.Exit();
    }

    public void Update()
    {
        
    }
}
