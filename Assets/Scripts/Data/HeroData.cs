using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroData : MonoBehaviour
{

    private int id;
    private string name;
    private int level;
    private Sprite heroSprite;

    private bool isOpened;
    private bool isSquaded;

    public HeroData(HeroSOData heroSOData, HeroSLData heroSLData)
    {

    }

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public int Level { get => level; set => level = value; }
    public Sprite HeroSprite { get => heroSprite; set => heroSprite = value; }
    public bool IsOpened { get => isOpened; set => isOpened = value; }
    public bool IsSquaded { get => isSquaded; set => isSquaded = value; }
}
