using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class HeroSummonService
{
    [SerializeField] private int heroCost = 5;
    private List<HeroData> _closedHerolist;
    private HeroesDataService _heroesDataService;
    private HeroesPanelService _heroesPanelService;
    private JewelryDataService _jewelryDataService;
    private HeroSummonView heroSummonView;

    [Inject]
    public HeroSummonService(HeroesDataService heroesDataService, HeroesPanelService heroesPanelService, JewelryDataService jewelryDataService)
    {
        heroSummonView = MonoBehaviour.FindObjectOfType<HeroSummonView>();
        heroSummonView.Init(this);
        _heroesDataService = heroesDataService;
        //вот тут heroesPanelService не должно быть
        _heroesPanelService = heroesPanelService;
        _jewelryDataService = jewelryDataService;
    }

    public void SummonHero()
    {
        if (_jewelryDataService.SpendScrolls(heroCost))
        {
            _closedHerolist = _heroesDataService.GetClosedHeroList();
            if (_closedHerolist.Count > 0)
            {
                int randomindex = Random.Range(0, _closedHerolist.Count);
                HeroData summonedHero = _closedHerolist[randomindex];
                _heroesDataService.OpenHero(_closedHerolist[randomindex].HeroSOData.Id);
                Debug.Log(summonedHero.HeroSOData.name);
                // вот тут исправить через ивент
                _heroesPanelService.UpdateHeroCards();
            }
        }
    }
}
