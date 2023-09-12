using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HeroPanelService 
{
    private List<HeroCardService> _heroCardServices;
    private List<HeroCardView> _heroCardViews;

    private HeroPanelView _heroPanelView;


    private List<HeroData> _heroesData;

    [Inject]
    public HeroPanelService(HeroesDataService heroesDataService)
    {
        _heroPanelView = MonoBehaviour.FindObjectOfType<HeroPanelView>();
        _heroCardViews = new List<HeroCardView>();
        _heroCardViews = _heroPanelView.GetHeroCardViews();

        _heroesData = heroesDataService.GetHeroessData();

        _heroCardServices = new List<HeroCardService>();
        for (int i = 0; i < _heroesData.Count; i++)
        {
            _heroCardServices.Add(new HeroCardService(_heroCardViews[i], _heroesData[i]));
        }

    }



}
