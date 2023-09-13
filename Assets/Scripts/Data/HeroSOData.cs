using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HeroSOData : ScriptableObject
{
    [SerializeField] private int _id;
    [SerializeField] private string _heroName;
    [SerializeField] private List<Sprite> _heroSprite = new List<Sprite>();

    public int Id { get => _id;}
    public string Name { get => _heroName;}

    public List<Sprite> HeroSprite { get => _heroSprite; }
}
