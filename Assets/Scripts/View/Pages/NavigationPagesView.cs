using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationPagesView : MonoBehaviour
{
    [SerializeField] private Button _heroesButton;
    [SerializeField] private Button _raidButton;
    [SerializeField] private Button _shopButton;
    private NavigationPagesService _navigationPagesService;

    public void Init(NavigationPagesService navigationPagesService)
    {
        _navigationPagesService = navigationPagesService;
        _heroesButton.onClick.AddListener(OpenHeroesPage);
        _raidButton.onClick.AddListener(OpenRaidPage);
        _shopButton.onClick.AddListener(OpenShopPage);
    }

    public void OpenHeroesPage()
    {
        _navigationPagesService.OpenHeroesPage();
    }

    public void OpenRaidPage()
    {
        _navigationPagesService.OpenRaidPage();
    }

    public void OpenShopPage()
    {
        _navigationPagesService.OpenShopPage();
    }

}
