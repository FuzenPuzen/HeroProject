using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPageService : IServiceState
{
    private ShopPageView _shopPageView;

    public ShopPageService()
    {
        _shopPageView = MonoBehaviour.FindObjectOfType<ShopPageView>();
        _shopPageView.Init(this);
    }

    public void Enter()
    {
        _shopPageView.Enter();
    }

    public void Exit()
    {
        _shopPageView.Exit();
    }

    public void Update()
    {

    }
}
