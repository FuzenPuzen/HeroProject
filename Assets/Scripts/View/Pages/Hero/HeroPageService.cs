
using UnityEngine;

public class HeroPageService : IServiceState
{
    private HeroPageView _heroPageView;

    public HeroPageService()
    {
        _heroPageView = MonoBehaviour.FindObjectOfType<HeroPageView>();
        _heroPageView.Init(this);
    }

    public void Enter()
    {
        _heroPageView.Enter();
    }

    public void Exit()
    {
        _heroPageView.Exit();
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}
