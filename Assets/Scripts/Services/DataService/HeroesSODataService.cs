using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


public class HeroesSODataService
{
    private List<HeroSOData> _heroesSOData = new List<HeroSOData>();

    public HeroesSODataService()
    {
        _heroesSOData.AddRange(Resources.LoadAll("Hero/HeroesSO", typeof(HeroSOData)));
        SortSO();
    }

    public void SortSO()
    {
        _heroesSOData = _heroesSOData.OrderBy(heroesSOData => heroesSOData.Id).ToList();
    }

    public List<HeroSOData> GetHeroesSOData() { return _heroesSOData; }

    public int GetHeroesSOCount() { return _heroesSOData.Count; }

}
