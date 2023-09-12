using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesSODataService
{
    private List<HeroSOData> _heroesSOData = new List<HeroSOData>();

    public HeroesSODataService()
    {

    }

    public List<HeroSOData> GetHeroesSOData() { return _heroesSOData; }

}
