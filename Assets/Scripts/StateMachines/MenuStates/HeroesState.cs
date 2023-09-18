using Zenject;

public class HeroesState : IBaseGameState
{
    private MenuStateMachine _menuStateMachine;
    private HeroPageService _heroPageService;

    [Inject]
    private HeroesState(MenuStateMachine menuStateMachine, HeroPageService heroPageService)
    {
        _menuStateMachine = menuStateMachine;
        _heroPageService = heroPageService;
    }

    public void Enter()
    {
        _heroPageService.Enter();
    }

    public void Exit()
    {
        _heroPageService.Exit();
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}
