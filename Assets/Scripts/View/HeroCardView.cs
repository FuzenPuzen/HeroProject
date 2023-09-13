using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static HeroPanelService;

public class HeroCardView : MonoBehaviour
{
    [SerializeField] private Image _cardImg;
    [SerializeField] private Image _heroImg;

    public void Init(HeroData heroData)
    {
        gameObject.SetActive(false);
        if (!heroData.HeroSLData.IsOpened) return;
        gameObject.SetActive(true);
    }


}
