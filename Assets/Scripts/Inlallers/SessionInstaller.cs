using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SessionInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<HeroUnitFabric>().AsSingle();
        Container.Bind<HeroUnitSquadService>().AsSingle();

        Container.Bind<EnemyUnitFabric>().AsSingle();
        Container.Bind<EnemyUnitSquadService>().AsSingle();

        Container.Bind<StateMachine>().AsSingle();
        Container.Bind<StartSessionState>().AsSingle();
        Container.Bind<BattleState>().AsSingle();
        Container.Bind<FormationState>().AsSingle();
    }
}
