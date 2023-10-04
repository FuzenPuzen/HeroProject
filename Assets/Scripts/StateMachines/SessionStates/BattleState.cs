

using Zenject;

public class BattleState : IBaseGameState
{

    private HeroUnitSquadService _heroUnitSquadService;
    private StateMachine _stateMachine;

    [Inject]
    public BattleState(HeroUnitSquadService heroUnitSquadService, StateMachine stateMachine)
    {
        _heroUnitSquadService = heroUnitSquadService;
        _stateMachine = stateMachine;
    }

    public void Enter()
    {

    }

    public void Exit()
    {
       
    }

    public void Update()
    {
      
    }
}
