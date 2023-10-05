using Zenject;

public class HeroesState : IBaseGameState
{
    private StateMachine _menuStateMachine;
    private HeroPageService _heroPageService;
    private HeroSummonService _heroSummonService;
    private HeroesPanelService _heroPanelService;
    private NavigationPagesService _navigationPagesService;

    [Inject]
    private HeroesState
    (
        StateMachine menuStateMachine, 
        HeroPageService heroPageService, 
        HeroSummonService heroSummonService,
        HeroesPanelService heroesPanelService,
        NavigationPagesService navigationPagesService
    )
    {
        _menuStateMachine = menuStateMachine;
        _heroPageService = heroPageService;
        _heroSummonService = heroSummonService;
        _heroPanelService = heroesPanelService;
        _navigationPagesService = navigationPagesService;
    }

    public void Enter()
    {
        _navigationPagesService.ActivateService();
        _navigationPagesService.SetChangePageInstruction(ChangePage);

        _heroPanelService.ActivateService();

        _heroSummonService.ActivateService();

        _heroPageService.Enter();
    }

    public void Exit()
    {
        _heroPageService.Exit();

        _heroPanelService.DeactivateService();
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
