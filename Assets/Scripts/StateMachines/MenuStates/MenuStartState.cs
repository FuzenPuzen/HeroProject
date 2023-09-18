using Zenject;

public class MenuStartState : IBaseGameState
{
    private MenuStateMachine _menuStateMachine;
    private HeroesState _heroesState;
    private NavigationPagesService _navigationPagesService;

    [Inject]
    public MenuStartState(MenuStateMachine menuStateMachine, NavigationPagesService navigationPagesService, HeroesState heroesState)
    {
        _heroesState = heroesState;
        _menuStateMachine = menuStateMachine;
        _navigationPagesService = navigationPagesService;
    }
    public void Enter()
    {
        _navigationPagesService.Init();
        _menuStateMachine.SetState(_heroesState);
    }

    public void Exit()
    {
        
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}
