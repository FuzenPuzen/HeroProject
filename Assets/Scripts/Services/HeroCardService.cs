using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCardService
{
    private HeroCardView _heroCardView;
    private HeroData _heroData;

    public HeroCardService(HeroCardView heroCardView, HeroData heroData)
    {
        _heroData = heroData;
        _heroCardView = heroCardView;
        _heroCardView.Init(_heroData);        
    }

    public void UpdateCardView()
    {
        _heroCardView.Init(_heroData);
    }
    
}
