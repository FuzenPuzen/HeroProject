using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class EnemyUnitSquadService : IServiceState, IFormationGameState, IBattleGameState
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

    public void Enter()
    {

    }

    public void Exit()
    {
        Debug.Log("Exit State");
    }
    public void Update()
    {

    }

    public void SpawnSquad()
    {
        _enemySquad = _enemySquad.Any() ? _enemySquad : _enemySODataService.GetEnemySquad();
        foreach (EnemySOData enemy in _enemySquad)
        {
            _enemyUnitSquad.Add(_enemyUnitFabric.CreateEnemy(enemy));
        }
    }

    public void EnterFormationState()
    {
        SpawnSquad();
        Debug.Log("EnemyEnterFormationState");
    }

    public void EnterBattleState()
    {
        Debug.Log("EnemyEnterBattleState");
    }
}
