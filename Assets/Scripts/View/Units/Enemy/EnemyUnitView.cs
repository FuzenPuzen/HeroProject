using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitView : MonoBehaviour
{
    [SerializeField] private int _id;

    public int Id { get => _id; set => _id = value; }
}
