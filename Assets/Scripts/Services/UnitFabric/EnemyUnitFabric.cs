using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

public class EnemyUnitFabric
{
    private List<EnemyUnitView> EnemiesPb = new List<EnemyUnitView>();
    private EnemyUnitView _enemy;

    public EnemyUnitFabric()
    {
        LoadEnemiesPb();
    }

    public void LoadEnemiesPb()
    {
        EnemiesPb.AddRange(Resources.LoadAll("Enemy/EnemyPb", typeof(EnemyUnitView)));
        SortPb();
    }

    public void SortPb()
    {
        EnemiesPb = EnemiesPb.OrderBy(EnemyUnitView => EnemyUnitView.Id).ToList();
    }

    public EnemyUnitService CreateEnemy(EnemySOData enemySOData)
    {
        _enemy = MonoBehaviour.Instantiate(EnemiesPb[enemySOData.Id], Vector3.zero, Quaternion.identity);
        return new EnemyUnitService(_enemy);
    }
}
