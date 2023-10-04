using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Newtonsoft.Json;
using System;

public class JewelryDataService
{
    public event Action JewerlyChange;
    private JewelryData _jewelryData;
    private string _jewelryDataKey = "jewelryDataKey";

    public JewelryDataService()
    {
        if (PlayerPrefs.HasKey(_jewelryDataKey))
        {
            LoadJewerlyData();
        }
        else
        {
            CreateJewerlyData();
            SaveJewerlyData();
        }
    }

    public JewelryData GetJewelryData() {return _jewelryData; }

    public bool SpendDiamonds(int cost)
    {
        if (_jewelryData.DiamondsCount >= cost)
        {
            _jewelryData.DiamondsCount -= cost;
            SaveJewerlyData();
            JewerlyChange?.Invoke();
            return true;
        }
        return false;
    }
    public void AddDiamonds(int cost)
    {
        _jewelryData.DiamondsCount += cost;
        SaveJewerlyData();
        JewerlyChange?.Invoke();
    }

    public bool SpendDollars(int cost)
    {
        if (_jewelryData.DollarsCount >= cost)
        {
            _jewelryData.DollarsCount -= cost;
            SaveJewerlyData();
            JewerlyChange?.Invoke();
            return true;
        }
        return false;
    }
    public void AddDollars(int cost)
    {
        _jewelryData.DollarsCount += cost;
        SaveJewerlyData();
        JewerlyChange?.Invoke();
    }

    public bool SpendScrolls(int cost)
    {
        if (_jewelryData.ScrollsCount >= cost)
        {
            _jewelryData.ScrollsCount -= cost;
            SaveJewerlyData();
            JewerlyChange?.Invoke();
            return true;
        }
        Debug.Log("Свитков больше нет!!");       
        return false;
    }

    public void AddScrolls(int cost)
    {
        _jewelryData.ScrollsCount += cost;
        SaveJewerlyData();
        JewerlyChange?.Invoke();
    }
    
    public void CreateJewerlyData()
    {
        _jewelryData = new JewelryData();
    }

    public void LoadJewerlyData()
    {
        string json = PlayerPrefs.GetString(_jewelryDataKey, "");
        _jewelryData = JsonConvert.DeserializeObject<JewelryData>(json);
    }

    public void SaveJewerlyData()
    {
        string json = JsonConvert.SerializeObject(_jewelryData);
        PlayerPrefs.SetString(_jewelryDataKey, json);
        PlayerPrefs.Save();
    }

}
