using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroData : MonoBehaviour
{
    private HeroSOData _heroSOData;
    private HeroSLData _heroSLData;

    public HeroData(HeroSOData heroSOData, HeroSLData heroSLData)
    {
        _heroSOData = heroSOData;
        _heroSLData = heroSLData;
    }

    public HeroSOData HeroSOData { get => _heroSOData; }
    public HeroSLData HeroSLData { get => _heroSLData;}
}
