
using UnityEngine;

[CreateAssetMenu]
public class EnemySOData : ScriptableObject
{
    [SerializeField] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private int _hp;
    [SerializeField] private int _speed;

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public int Hp { get => _hp; set => _hp = value; }
    public int Speed { get => _speed; set => _speed = value; }
}
