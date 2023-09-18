using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPageView : MonoBehaviour, IViewState
{
    private HeroPageService _heroPageService;
    public GameObject _heroPage;

    public void Init(HeroPageService heroPageService)
    {
        _heroPageService = heroPageService;
    }

    public void Enter()
    {
        _heroPage.SetActive(true);
    }

    public void Exit()
    {
        _heroPage.SetActive(false);
    }


    public void UpdateView()
    {
        throw new NotImplementedException();
    }
}
