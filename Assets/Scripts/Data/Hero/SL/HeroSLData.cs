using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroSLData
{
    [SerializeField] private int _id;
    [SerializeField] private int _level;
    [SerializeField] private bool _isOpened;
    [SerializeField] private bool _isSquaded;

    public HeroSLData(int id)
    {
        _id = id;
        _level = 0;
        _isOpened = false;
        _isSquaded = false;
    }

    public int Level { get => _level; set => _level = value; }
    public bool IsOpened { get => _isOpened; set => _isOpened = value; }
    public bool IsSquaded { get => _isSquaded; set => _isSquaded = value; }
    public int Id { get => _id;}
}
