using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class HeroesDataService
{

    private List<HeroData> heroesData = new List<HeroData>();

    [Inject]
    public HeroesDataService(HeroesSODataService heroesSODataService, HeroesSLDataService heroesSLDataService)
    {
        List<HeroSOData> heroesSOData = new List<HeroSOData>();
        heroesSOData = heroesSODataService.GetHeroesSOData();

        List<HeroSLData> heroesSLData = new List<HeroSLData>();
        heroesSLData = heroesSLDataService.GetHeroesSLData();

        FillHeroesData(heroesSOData, heroesSLData);
    }

    // Наполнение heroData 
    private void FillHeroesData(List<HeroSOData> heroesSOData, List<HeroSLData> heroesSLData)
    {
        for (int i = 0; i < heroesSOData.Count; i++)
        {
            heroesData.Add(new HeroData(heroesSOData[i], heroesSLData[i]));
        }
    }

    public List<HeroData> GetHeroessData()
    {
        return heroesData;
    }

}
