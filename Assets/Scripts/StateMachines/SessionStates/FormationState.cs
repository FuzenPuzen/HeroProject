
public class FormationState : IBaseGameState
{
    private HeroUnitSquadService _heroUnitSquadService;
    private StateMachine _stateMachine;
    private BattleState _battleState;

    public FormationState(HeroUnitSquadService heroUnitSquadService, StateMachine stateMachine, BattleState battleState)
    {
        _heroUnitSquadService = heroUnitSquadService;
        _battleState = battleState;
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        _heroUnitSquadService.EnterFormationState();
        _stateMachine.SetState(_battleState);

    }

    public void Exit()
    {
        _heroUnitSquadService.Exit();
    }

    public void Update()
    {
        
    }
}
