using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class JewelryDataService
{
    [Inject] private JewelryData _jewelryData;
    private JewerlyPanelView _jewerlyDataView;
    private string _jewelryDataKey = "jewelryDataKey";

    public bool SpendDiamonds(int cost)
    {
        if (_jewelryData.DiamondsCount >= cost)
        {
            _jewelryData.DiamondsCount -= cost;
            _jewerlyDataView.UpdateView(_jewelryData);
            return true;
        }
        return false;

    }
    public void AddDiamonds(int cost)
    {
        _jewelryData.DiamondsCount += cost;
        _jewerlyDataView.UpdateView(_jewelryData);
    }

    public bool SpendDollars(int cost)
    {
        if (_jewelryData.DollarsCount >= cost)
        {
            _jewelryData.DollarsCount -= cost;
            _jewerlyDataView.UpdateView(_jewelryData);
            return true;
        }
        return false;
    }
    public void AddDollars(int cost)
    {
        _jewelryData.DollarsCount += cost;
        _jewerlyDataView.UpdateView(_jewelryData);
    }

    public bool SpendScrolls(int cost)
    {
        if (_jewelryData.ScrollsCount >= cost)
        {
            _jewelryData.ScrollsCount -= cost;
            _jewerlyDataView.UpdateView(_jewelryData);
            return true;
        }
        return false;
    }
    public void AddScrolls(int cost)
    {
        _jewelryData.ScrollsCount += cost;
        _jewerlyDataView.UpdateView(_jewelryData);
    }

    
    public JewelryDataService()
    {
        _jewerlyDataView = MonoBehaviour.FindObjectOfType<JewerlyPanelView>();

        if (!PlayerPrefs.HasKey(_jewelryDataKey))
        {
            CreateJewerlyData();
            SaveJewerlyData();
        }
        else
        {
            LoadJewerlyData();
        }
        _jewerlyDataView.UpdateView(_jewelryData);
    }

    public void CreateJewerlyData()
    {
        _jewelryData = new JewelryData();
        _jewelryData.DiamondsCount = 0;
        _jewelryData.DollarsCount = 0;
        _jewelryData.ScrollsCount = 0;
    }

    public void LoadJewerlyData()
    {
        string json = PlayerPrefs.GetString(_jewelryDataKey, "");
        _jewelryData = JsonUtility.FromJson<JewelryData>(json);
    }

    public void SaveJewerlyData()
    {
        string json = JsonUtility.ToJson(_jewelryData);
        PlayerPrefs.SetString(_jewelryDataKey, json);
        PlayerPrefs.Save();
    }

}
