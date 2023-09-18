using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaidPageView : MonoBehaviour, IViewState
{
    private RaidPageService _raidPageService;
    public GameObject _raidPage;

    public void Init(RaidPageService raidPageService)
    {
        _raidPageService = raidPageService;
    }

    public void Enter()
    {
        _raidPage.SetActive(true);
    }

    public void Exit()
    {
        _raidPage.SetActive(false);
    }


    public void UpdateView()
    {
        throw new NotImplementedException();
    }
}
