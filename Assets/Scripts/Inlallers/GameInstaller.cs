using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //_container.Bind<DiContainer>().FromInstance(_container).AsSingle();
        Container.Bind<HeroesDataService>().AsSingle();
        Container.Bind<HeroesSODataService>().AsSingle();
        Container.Bind<HeroesSLDataService>().AsSingle();
    }
}