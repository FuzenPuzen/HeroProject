using UnityEngine;

public class RaidPageService : IServiceState
{
    private RaidPageView _raidPageView;

    public RaidPageService()
    {
        _raidPageView = MonoBehaviour.FindObjectOfType<RaidPageView>();
        _raidPageView.Init(this);
    }

    public void Enter()
    {
        _raidPageView.Enter();
    }

    public void Exit()
    {
        _raidPageView.Exit();
    }

    public void Update()
    {
        
    }
}
