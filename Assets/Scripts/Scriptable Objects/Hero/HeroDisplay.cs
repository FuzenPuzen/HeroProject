using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroDisplay : MonoBehaviour
{
    public HeroesSC heroesSC;

    public Image backgrowndIm;
    public Image heroIm;

    void Start()
    {
        backgrowndIm.sprite = heroesSC.backGrowndSprite;
        heroIm.sprite = heroesSC.heroSprite;
    }

}
