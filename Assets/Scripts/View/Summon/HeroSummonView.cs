using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Zenject;

public class HeroSummonView : MonoBehaviour
{
    [SerializeField] private Button _summonButton;
    
    private HeroSummonService _heroSummonService;
    private Action _cliced;

    void Start()
    {
        
    }

    public void Init(HeroSummonService heroSummonService, Action cliced)
    {
        _heroSummonService = heroSummonService;
        _cliced = cliced;
        _summonButton.onClick.AddListener(SummonCliced);
    }

    public void SummonCliced()
    {
        _cliced?.Invoke();
    }

}
