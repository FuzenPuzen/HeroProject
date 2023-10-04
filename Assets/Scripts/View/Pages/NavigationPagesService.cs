using System;
using UnityEngine;
using Zenject;

public class NavigationPagesService
{
    private NavigationPagesView _navigationPagesView;

    [Inject] private HeroesState _heroesState;
    [Inject] private RaidState _raidState;
    [Inject] private ShopState _shopState;

    private Action<IBaseGameState> _changePage;

    
    public NavigationPagesService()
    {

    }

    public void ActivateService()
    {
        _navigationPagesView = MonoBehaviour.FindObjectOfType<NavigationPagesView>();
        _navigationPagesView.Init(this);
        Debug.Log(_heroesState);
    }
  
    public void SetChangePageInstruction(Action<IBaseGameState> changePage)
    {
        _changePage = changePage;
    }

    public void OpenHeroesPage()
    {
        Debug.Log(_heroesState);
        _changePage?.Invoke(_heroesState);
    }

    public void OpenRaidPage()
    {
        _changePage?.Invoke(_raidState);
    }

    internal void OpenShopPage()
    {
        _changePage?.Invoke(_shopState);
    }

    internal void SetStartPageInstruction(Action<IBaseGameState> changePage)
    {
        changePage?.Invoke(_heroesState);
    }
}
