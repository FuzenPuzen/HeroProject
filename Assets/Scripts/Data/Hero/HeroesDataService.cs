using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

public class HeroesDataService
{
    public event Action HeroChanged;
    private List<HeroData> heroesData = new List<HeroData>();
    private HeroesSLDataService _heroesSLDataService;

    [Inject]
    public HeroesDataService(HeroesSODataService heroesSODataService, HeroesSLDataService heroesSLDataService)
    {
        List<HeroSOData> heroesSOData = new List<HeroSOData>();
        heroesSOData = heroesSODataService.GetHeroesSOData();

        _heroesSLDataService = heroesSLDataService;
        List<HeroSLData> heroesSLData = new List<HeroSLData>();
        heroesSLData = heroesSLDataService.GetHeroesSLData();

        FillHeroesData(heroesSOData, heroesSLData);
    }

    // Наполнение heroData 
    private void FillHeroesData(List<HeroSOData> heroesSOData, List<HeroSLData> heroesSLData)
    {
        for (int i = 0; i < heroesSOData.Count; i++)
        {
            HeroData herodata = new HeroData(heroesSOData[i], heroesSLData[i]);
            heroesData.Add(herodata);
        }
    }

    public List<HeroData> GetHeroessData()
    {
        return heroesData;
    }

    public List<HeroData> GetClosedHeroList()
    {
        List<HeroData> closedHeroList = new List<HeroData>();
        foreach (HeroData hero in heroesData)
            if (!hero.HeroSLData.IsOpened)
            {
                closedHeroList.Add(hero);
            }
                
        return closedHeroList;
    }


    public List<HeroData> GetHeroSquad()
    {
        List<HeroData> squadHeroList = new List<HeroData>();
        foreach (HeroData hero in heroesData)
            if (hero.HeroSLData.IsSquaded)
            {
                squadHeroList.Add(hero);
            }

        return squadHeroList;
    }

    public void OpenHero(int heroid)
    {
       heroesData[heroid].HeroSLData.IsOpened = true;
       _heroesSLDataService.SaveHeroSLData();
        HeroChanged?.Invoke();
    }

    public void PutHeroInSquad(int heroid)
    {
        heroesData[heroid].HeroSLData.IsSquaded = true;
        _heroesSLDataService.SaveHeroSLData();
        HeroChanged?.Invoke();
    }

}
