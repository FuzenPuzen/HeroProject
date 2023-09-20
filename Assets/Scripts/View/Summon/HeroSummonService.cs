using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class HeroSummonService
{
    [SerializeField] private int heroCost = 5;
    private List<HeroData> _closedHerolist;
    private HeroesDataService _heroesDataService;
    private JewelryDataService _jewelryDataService;
    private HeroSummonView heroSummonView;

    [Inject]
    public HeroSummonService(HeroesDataService heroesDataService, JewelryDataService jewelryDataService)
    {
        heroSummonView = MonoBehaviour.FindObjectOfType<HeroSummonView>();
        heroSummonView.Init(this);
        _heroesDataService = heroesDataService;
        _jewelryDataService = jewelryDataService;
    }
    
    public void SummonHero()
    {
        _closedHerolist = _heroesDataService.GetClosedHeroList();
        if (_closedHerolist.Count <= 0) return; // панелька что все герои открыты и не надо открывать новых
        if (_jewelryDataService.SpendScrolls(heroCost))
        {
            int randomindex = Random.Range(0, _closedHerolist.Count);
            HeroData summonedHero = _closedHerolist[randomindex];
            _heroesDataService.OpenHero(_closedHerolist[randomindex].HeroSOData.Id);
            Debug.Log(summonedHero.HeroSOData.name);
        }        
    }
}
