using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static HeroPanelService;

public class HeroCardService
{
    private HeroCardView _heroCardView;

    public HeroCardService(HeroCardView heroCardView, HeroData heroData)
    {
        _heroCardView = heroCardView;
        _heroCardView.Init(heroData);        
    }
    
}
