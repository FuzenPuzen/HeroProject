using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

public class HeroUnitFabric 
{
    private List<HeroUnitView> HeroesPb = new List<HeroUnitView>();
    private HeroUnitView hero;

    public HeroUnitFabric()
    {       
        LoadHeroesPb();
    }

    public void LoadHeroesPb()
    {
        HeroesPb.AddRange(Resources.LoadAll("Hero/HeroesPb", typeof(HeroUnitView)));
        SortPb();
    }

    public void SortPb()
    {
        HeroesPb = HeroesPb.OrderBy(HeroUnitView => HeroUnitView.Id).ToList();
    }

    public HeroUnitService CreateHero(HeroData heroData)
    {
        hero = MonoBehaviour.Instantiate(HeroesPb[heroData.HeroSLData.Id], Vector3.zero, Quaternion.identity);
        return new HeroUnitService(hero);
    }
}
