using Zenject;

public class HeroesState : IBaseGameState
{
    private MenuStateMachine _menuStateMachine;
    private HeroPageService _heroPageService;
    private HeroSummonService _heroSummonService;
    private HeroesPanelService _heroPanelService;

    [Inject]
    private HeroesState
    (
        MenuStateMachine menuStateMachine, 
        HeroPageService heroPageService, 
        HeroSummonService heroSummonService,
        HeroesPanelService heroesPanelService
    )
    {
        _menuStateMachine = menuStateMachine;
        _heroPageService = heroPageService;
        _heroSummonService = heroSummonService;
        _heroPanelService = heroesPanelService;
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
