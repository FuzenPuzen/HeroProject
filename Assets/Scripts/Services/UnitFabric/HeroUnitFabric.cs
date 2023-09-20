using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

public class HeroUnitFabric 
{   
    public List<GameObject> HeroesPb = new List<GameObject>();
    private GameObject hero;

    [Inject]
    public HeroUnitFabric()
    {       
        LoadHeroesPb();
    }

    public void LoadHeroesPb()
    {
        HeroesPb.AddRange(Resources.LoadAll("Hero/HeroesPb", typeof(GameObject)));
        SortPb();
    }

    public void SortPb()
    {
        HeroesPb = HeroesPb.OrderBy(GameObject => GameObject.GetComponent<HeroUnitView>().id).ToList();
    }

    public HeroUnitService CreateHero(HeroData heroData)
    {
        hero = MonoBehaviour.Instantiate(HeroesPb[heroData.HeroSLData.Id], Vector3.zero, Quaternion.identity);
        return new HeroUnitService(hero.GetComponent<HeroUnitView>());
    }
}
