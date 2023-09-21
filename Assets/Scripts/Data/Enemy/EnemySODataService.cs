using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySODataService 
{
    private List<EnemySOData> _enemySOData = new List<EnemySOData>();

    public EnemySODataService()
    {
        _enemySOData.AddRange(Resources.LoadAll("Enemy/EnemySO", typeof(EnemySOData)));
        SortSO();
    }

    public void SortSO()
    {
        _enemySOData = _enemySOData.OrderBy(enemySOData => enemySOData.Id).ToList();
    }

    public List<EnemySOData> GetEnemiesSOData() { return _enemySOData; }

    public int GetEnemiesSOCount() { return _enemySOData.Count; }

    internal List<EnemySOData> GetEnemySquad()
    {
        Debug.Log("Создать LevelSODataService");
        return _enemySOData;
    }
}
