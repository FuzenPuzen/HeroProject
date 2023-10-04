using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class EnemyUnitSquadService : IService
{
    private EnemySODataService _enemySODataService;
    private EnemyUnitFabric _enemyUnitFabric;

    private List<EnemyUnitService> _enemyUnitSquad = new List<EnemyUnitService>();
    private List<EnemySOData> _enemySquad = new List<EnemySOData>();

    [Inject]
    public EnemyUnitSquadService(EnemySODataService enemiesDataService, EnemyUnitFabric enemyUnitFabric)
    {
        _enemySODataService = enemiesDataService;
        _enemyUnitFabric = enemyUnitFabric;
    }

    public void FormationStateIstruction()
    {
        FillSquad();
    }

    public void ActivateService()
    {
        
    }

    public void DeactivateService()
    {
       
    }

    public void UpdateService()
    {
        throw new System.NotImplementedException();
    }

    public void FillSquad()
    {
        _enemySquad = _enemySquad.Any() ? _enemySquad : _enemySODataService.GetEnemySquad();
        foreach (EnemySOData enemy in _enemySquad)
        {
            _enemyUnitSquad.Add(_enemyUnitFabric.CreateEnemy(enemy));
        }
    }
}
