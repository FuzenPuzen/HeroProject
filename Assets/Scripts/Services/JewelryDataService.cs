using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Newtonsoft.Json;

public class JewelryDataService
{
    private JewelryData _jewelryData;
    private JewerlyPanelView _jewerlyPanelView;
    private string _jewelryDataKey = "jewelryDataKey";

    public bool SpendDiamonds(int cost)
    {
        if (_jewelryData.DiamondsCount >= cost)
        {
            _jewelryData.DiamondsCount -= cost;
            _jewerlyPanelView.UpdateView(_jewelryData);
            SaveJewerlyData();
            return true;
        }
        return false;
    }
    public void AddDiamonds(int cost)
    {
        _jewelryData.DiamondsCount += cost;
        _jewerlyPanelView.UpdateView(_jewelryData);
        SaveJewerlyData();
    }

    public bool SpendDollars(int cost)
    {
        if (_jewelryData.DollarsCount >= cost)
        {
            _jewelryData.DollarsCount -= cost;
            _jewerlyPanelView.UpdateView(_jewelryData);
            SaveJewerlyData();
            return true;
        }
        return false;
    }
    public void AddDollars(int cost)
    {
        _jewelryData.DollarsCount += cost;
        _jewerlyPanelView.UpdateView(_jewelryData);
        SaveJewerlyData();
    }

    public bool SpendScrolls(int cost)
    {
        if (_jewelryData.ScrollsCount >= cost)
        {
            _jewelryData.ScrollsCount -= cost;
            _jewerlyPanelView.UpdateView(_jewelryData);
            SaveJewerlyData();
            return true;
        }
        Debug.Log("Свитков больше нет!!");       
        return false;
    }
    public void AddScrolls(int cost)
    {
        _jewelryData.ScrollsCount += cost;
        _jewerlyPanelView.UpdateView(_jewelryData);
        SaveJewerlyData();
    }


    public JewelryDataService()
    {
        _jewerlyPanelView = MonoBehaviour.FindObjectOfType<JewerlyPanelView>();

        if (PlayerPrefs.HasKey(_jewelryDataKey))
        {
            LoadJewerlyData();
        }
        else
        {
            CreateJewerlyData();
            SaveJewerlyData();
        }
        _jewerlyPanelView.UpdateView(_jewelryData);
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
