using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPanelView : MonoBehaviour
{
    [SerializeField] private List<HeroCardView> _heroCardViews = new List<HeroCardView>();

    public List<HeroCardView> GetHeroCardViews()
    { 
        return _heroCardViews; 
    }
}
