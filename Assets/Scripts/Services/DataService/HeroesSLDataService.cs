using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;
using Newtonsoft.Json;

public class HeroesSLDataService
{ 
    private HeroesSODataService _heroesSODataService;
    private string _heroDataKey = "heroDataKey";
    [Serialize] private List<HeroSLData> _heroesSLData = new List<HeroSLData>();
    private int _heroCount;

    [Inject]
    public HeroesSLDataService(HeroesSODataService heroesSODataService)
    {
        _heroesSODataService = heroesSODataService;
        if (!PlayerPrefs.HasKey(_heroDataKey))
        {
            CreateHeroSLData();
            SaveHeroSLData();
        }
        else
        {
            LoadHeroSLData();
        }
    }

    private void CreateHeroSLData()
    {
        _heroCount = _heroesSODataService.GetHeroesSOCount();
        for (int i = 0; i < _heroCount; i++)
        {
            _heroesSLData.Add(new HeroSLData(i));
            if (i % 2 == 0)
            {
                
                _heroesSLData[i].IsOpened = false;
            }
        }
    }

    private void LoadHeroSLData()
    {
        string json = PlayerPrefs.GetString(_heroDataKey, "");
        _heroesSLData = JsonConvert.DeserializeObject<List<HeroSLData>>(json);
    }

    public void SaveHeroSLData()
    {
        string json = JsonConvert.SerializeObject(_heroesSLData);
        PlayerPrefs.SetString(_heroDataKey, json);
        PlayerPrefs.Save();
    }

    public List<HeroSLData> GetHeroesSLData() { return _heroesSLData; }
}