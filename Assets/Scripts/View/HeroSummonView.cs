using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class HeroSummonView : MonoBehaviour, IPointerClickHandler
{
    
    private HeroSummonService _heroSummonService;

    void Start()
    {

    }

    public void Init(HeroSummonService heroSummonService)
    {
        _heroSummonService = heroSummonService;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _heroSummonService.SummonHero();
    }

}
