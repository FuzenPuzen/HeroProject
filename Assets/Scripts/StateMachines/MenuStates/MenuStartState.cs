using Zenject;

public class MenuStartState : IBaseGameState
{
    private MenuStateMachine _menuStateMachine;
    private HeroesState _heroesState;
    private NavigationPagesService _navigationPagesService;
    private JewelryDataService _jewelryDataService;
    private JewerlyPanelService _jewerlyPanelService;

    [Inject]
    public MenuStartState
    (
        MenuStateMachine menuStateMachine, 
        NavigationPagesService navigationPagesService, 
        HeroesState heroesState,
        JewelryDataService jewelryDataService,
        JewerlyPanelService jewerlyPanelService
    )
    {
        _jewelryDataService = jewelryDataService;
        _jewerlyPanelService = jewerlyPanelService;
        _heroesState = heroesState;
        _menuStateMachine = menuStateMachine;
        _navigationPagesService = navigationPagesService;
    }

    public void Enter()
    {
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
