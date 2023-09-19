using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JewerlyPanelView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _dollarsText;
    [SerializeField] private TextMeshProUGUI _diamondsText;
    [SerializeField] private TextMeshProUGUI _scrollsText;   

    public void UpdateView(JewelryData jewelryData)
    {
        _dollarsText.text = jewelryData.DollarsCount.ToString();
        _diamondsText.text = jewelryData.DiamondsCount.ToString();
        _scrollsText.text = jewelryData.ScrollsCount.ToString();
    }

}
