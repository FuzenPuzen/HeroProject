
using System.Diagnostics;
using UnityEngine;
using Zenject;

public class RaidState : IBaseGameState
{
    private StateMachine _menuStateMachine;
    private RaidPageService _raidPageService;
    private NavigationPagesService _navigationPagesService;

    [Inject]
    private RaidState(StateMachine menuStateMachine, RaidPageService raidPageService, NavigationPagesService navigationPagesService)
    {
        _menuStateMachine = menuStateMachine;
        _raidPageService = raidPageService;
        _navigationPagesService = navigationPagesService;
    }

    public void Enter()
    {
        _navigationPagesService.SetChangePageInstruction(ChangePage);
        _raidPageService.Enter();
    }

    public void Exit()
    {
        _raidPageService.Exit();
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
