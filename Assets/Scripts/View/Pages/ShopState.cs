using Zenject;

public class ShopState : IBaseGameState
{
    private MenuStateMachine _menuStateMachine;
    private ShopPageService _shopPageService;

    [Inject]
    private ShopState(MenuStateMachine menuStateMachine, ShopPageService shopPageService)
    {
        _menuStateMachine = menuStateMachine;
        _shopPageService = shopPageService;
    }

    public void Enter()
    {
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
}