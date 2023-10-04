using Zenject;

public class ShopState : IBaseGameState
{
    private StateMachine _menuStateMachine;
    private ShopPageService _shopPageService;
    private NavigationPagesService _navigationPagesService;

    [Inject]
    private ShopState(StateMachine menuStateMachine, ShopPageService shopPageService, NavigationPagesService navigationPagesService)
    {
        _menuStateMachine = menuStateMachine;
        _shopPageService = shopPageService;
        _navigationPagesService = navigationPagesService;
    }

    public void Enter()
    {
        _navigationPagesService.SetChangePageInstruction(ChangePage);
        _shopPageService.Enter();
    }

    public void Exit()
    {
        _shopPageService.Exit();
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }

    public void ChangePage(IBaseGameState currentstate)
    {
        _menuStateMachine.SetState(currentstate);
    }
}