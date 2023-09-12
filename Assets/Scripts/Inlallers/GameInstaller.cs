using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    private DiContainer _container = new DiContainer();


    public override void InstallBindings()
    {
        _container.Bind<HeroesDataService>().AsSingle();
        _container.Bind<HeroesSODataService>().AsSingle();
        _container.Bind<HeroesSLDataService>().AsSingle();

    }
}