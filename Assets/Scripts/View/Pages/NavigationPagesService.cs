using System;
using UnityEngine;
using Zenject;

public class NavigationPagesService
{
    private NavigationPagesView _navigationPagesView;
    private MenuStateMachine _menuStateMachine;
    private HeroesState _heroesState;
    private RaidState _raidState;
    private ShopState _shopState;

    public void Init()
    {
        MonoBehaviour.print("NavigationPagesService Init");
    }

    [Inject]
    public NavigationPagesService
    (
        MenuStateMachine menuStateMachine,
        HeroesState heroesState, 
        RaidState raidState,
        ShopState shopState
    )
    {
        
        _menuStateMachine = menuStateMachine;
        _shopState = shopState;
        _heroesState = heroesState;
        _raidState = raidState;
        _navigationPagesView = MonoBehaviour.FindObjectOfType<NavigationPagesView>();
        _navigationPagesView.Init(this);
    }

    public void OpenHeroesPage()
    {
        _menuStateMachine.SetState(_heroesState);
    }

    public void OpenRaidPage()
    {
        _menuStateMachine.SetState(_raidState);
    }

    internal void OpenShopPage()
    {
        _menuStateMachine.SetState(_shopState);
    }
}
