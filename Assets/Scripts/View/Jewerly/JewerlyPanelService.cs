
using System;
using UnityEngine;
using Zenject;

public class JewerlyPanelService
{
    private JewerlyPanelView _jewerlyPanelView;
    private JewelryDataService _jewelryDataService;

    [Inject]
    public JewerlyPanelService(JewelryDataService jewelryDataService)
    {
        _jewerlyPanelView = MonoBehaviour.FindObjectOfType<JewerlyPanelView>();
        _jewelryDataService = jewelryDataService;
        _jewelryDataService.JewerlyChange += UpdateView;
        UpdateView();
    }

    internal void UpdateView()
    {
        _jewerlyPanelView.UpdateView(_jewelryDataService.GetJewelryData());
    }
}
