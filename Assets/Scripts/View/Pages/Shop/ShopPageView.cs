using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPageView : MonoBehaviour, IViewState
{
    private ShopPageService _shopPageService;
    public GameObject _shopPage;

    public void Init(ShopPageService shopPageService)
    {
        _shopPageService = shopPageService;
    }

    public void Enter()
    {
        _shopPage.SetActive(true);
    }

    public void Exit()
    {
        _shopPage.SetActive(false);
    }


    public void UpdateView()
    {
        
    }
}
