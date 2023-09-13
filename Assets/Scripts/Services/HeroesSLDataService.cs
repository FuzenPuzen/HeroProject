using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public interface IHeroesSLDataService
{
    List<HeroSLData> GetHeroesSLData();
}

public class HeroesSLDataService : IHeroesSLDataService
{
    private string _heroDataKey = "heroDataKey";
    private List<HeroSLData> _heroesSLData = new List<HeroSLData>();
    private int _heroCount;
    private HeroesSODataService _heroesSODataService;

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
        }
    }

    private void LoadHeroSLData()
    {
        string json = PlayerPrefs.GetString(_heroDataKey, "");
        // Десериализуем JSON в список
        _heroesSLData = JsonUtility.FromJson<List<HeroSLData>>(json);
    }

    private void SaveHeroSLData()
    {
        string json = JsonUtility.ToJson(_heroesSLData);
        // Сохраняем JSON в PlayerPrefs
        PlayerPrefs.SetString("PlayerData", json);
        PlayerPrefs.Save();
    }

    public List<HeroSLData> GetHeroesSLData() { return _heroesSLData; }
}