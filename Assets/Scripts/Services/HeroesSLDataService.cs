using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesSLDataService : MonoBehaviour
{
    private List<HeroSLData> _heroesSLData = new List<HeroSLData>();

    public HeroesSLDataService()
    {

    }

    public List<HeroSLData> GetHeroesSLData() { return _heroesSLData; }
}
