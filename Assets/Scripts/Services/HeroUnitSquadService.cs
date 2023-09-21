using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class HeroUnitSquadService : IServiceState, IFormationGameState, IBattleGameState
{
    private HeroesDataService _heroesDataService;
    private HeroUnitFabric _heroUnitFabric;

    private List<HeroUnitService> _heroUnitSquad = new List<HeroUnitService>();
    private List<HeroData> _heroSquad = new List<HeroData>();

    [Inject]
    public HeroUnitSquadService(HeroesDataService heroesDataService, HeroUnitFabric heroUnitFabric)
    {
        _heroesDataService = heroesDataService;
        _heroUnitFabric = heroUnitFabric;
    }

    public void Enter()
    {

    }

    public void Exit()
    {
        Debug.Log("Exit State");
    }
    public void Update()
    {

    }

    public void SpawnSquad()
    {
        _heroSquad = _heroSquad.Any() ? _heroSquad : _heroesDataService.GetHeroSquad();
        foreach (HeroData hero in _heroSquad)
        {
            _heroUnitSquad.Add(_heroUnitFabric.CreateHero(hero));
        }
    }

    public void EnterFormationState()
    {
        SpawnSquad();
        Debug.Log("EnterFormationState");
    }

    public void EnterBattleState()
    {
        Debug.Log("EnterBattleState");
    }


}
