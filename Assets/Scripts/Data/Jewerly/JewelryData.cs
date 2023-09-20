using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class JewelryData
{
    [SerializeField] private int _diamondsCount;
    [SerializeField] private int _dollarsCount;
    [SerializeField] private int _scrollsCount;

    public JewelryData()
    {
        _diamondsCount = 0;
        _dollarsCount = 0;
        _scrollsCount = 0;
    }

    public int DiamondsCount { get => _diamondsCount; set => _diamondsCount = value; }
    public int DollarsCount { get => _dollarsCount; set => _dollarsCount = value; }
    public int ScrollsCount { get => _scrollsCount; set => _scrollsCount = value; }
}
