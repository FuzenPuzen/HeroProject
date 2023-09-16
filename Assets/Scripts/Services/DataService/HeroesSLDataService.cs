using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;



public class HeroesSLDataService
{ 
    private HeroesSODataService _heroesSODataService;
    private string _heroDataKey = "heroDataKey";
    [SerializeField] private List<HeroSLData> _heroesSLData = new List<HeroSLData>();
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
                _heroesSLData[i].IsOpened = true;
            }
        }
    }

    private void LoadHeroSLData()
    {
        string json = PlayerPrefs.GetString(_heroDataKey, "");
        _heroesSLData = JsonUtility.FromJson<List<HeroSLData>>(json);
    }

    private void SaveHeroSLData()
    {
        string json = JsonUtility.ToJson(_heroesSLData);
        PlayerPrefs.SetString(_heroDataKey, json);
        PlayerPrefs.Save();
    }

    public List<HeroSLData> GetHeroesSLData() { return _heroesSLData; }
}