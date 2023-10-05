using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HeroesPanelService 
{
    private bool isFirstActive;
    private List<HeroCardService> _heroCardServices;
    private List<HeroCardView> _heroCardViews;

    private HeroPanelView _heroPanelView;

    private HeroesDataService _heroesDataService;
    private List<HeroData> _heroesData;

    [Inject]
    public HeroesPanelService(HeroesDataService heroesDataService)
    {
        _heroesDataService = heroesDataService;
        isFirstActive = true;
    }

    public void ActivateService()
    {
        _heroesDataService.HeroChanged += UpdateHeroCards;
        if (isFirstActive)
        { 
            _heroesData = _heroesDataService.GetHeroessData();
            _heroPanelView = MonoBehaviour.FindObjectOfType<HeroPanelView>();
            CreateCards();
            isFirstActive = false;
        }
    }

    public void CreateCards()
    {
        _heroCardViews = new List<HeroCardView>();
        _heroCardViews = _heroPanelView.GetHeroCardViews();
        _heroCardServices = new List<HeroCardService>();
        if(_heroCardServices == null)
            for (int i = 0; i < _heroesData.Count; i++)
            {
                _heroCardServices.Add(new HeroCardService(_heroCardViews[i], _heroesData[i]));
            }
    }

    public void UpdateHeroCards()
    {
        foreach(HeroCardService heroCardService in _heroCardServices)
            heroCardService.UpdateCardView();
    }

    public void DeactivateService()
    {
        _heroesDataService.HeroChanged -= UpdateHeroCards;
    }

}
