using Zenject;

public class MenuStartState : IBaseGameState
{
    private StateMachine _menuStateMachine;
    private NavigationPagesService _navigationPagesService;
    private JewelryDataService _jewelryDataService;
    private JewerlyPanelService _jewerlyPanelService;

    [Inject]
    public MenuStartState
    (
        StateMachine menuStateMachine, 
        JewelryDataService jewelryDataService,
        JewerlyPanelService jewerlyPanelService,
        NavigationPagesService navigationPagesService
    )
    {
        _jewelryDataService = jewelryDataService;
        _jewerlyPanelService = jewerlyPanelService;
        _menuStateMachine = menuStateMachine;
        _navigationPagesService = navigationPagesService;
    }

    public void Enter()
    {
        _navigationPagesService.SetStartPageInstruction(ChangePage);
    }

    public void Exit()
    {
        
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
