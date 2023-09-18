
using System.Diagnostics;
using UnityEngine;
using Zenject;

public class RaidState : IBaseGameState
{
    private MenuStateMachine _menuStateMachine;
    private RaidPageService _raidPageService;

    [Inject]
    private RaidState(MenuStateMachine menuStateMachine, RaidPageService raidPageService)
    {
        _menuStateMachine = menuStateMachine;
        _raidPageService = raidPageService;
    }

    public void Enter()
    {
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
}
