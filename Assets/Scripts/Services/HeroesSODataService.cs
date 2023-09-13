using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface IHeroesSODataService
{
    public int GetHeroesSOCount();
}

public class HeroesSODataService : IHeroesSODataService
{
    private List<HeroSOData> _heroesSOData = new List<HeroSOData>();

    public HeroesSODataService()
    {
        _heroesSOData.AddRange(Resources.LoadAll("Hero/HeroesSO", typeof(HeroSOData)));
    }

    public List<HeroSOData> GetHeroesSOData() { return _heroesSOData; }

    public int GetHeroesSOCount() { return _heroesSOData.Count; }

}
