using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<HeroesSODataService>().AsSingle();
        Container.Bind<HeroesSLDataService>().AsSingle();

        Container.Bind<HeroesDataService>().AsSingle();
        Container.Bind<HeroesPanelService>().AsSingle();

        Container.Bind<JewelryDataService>().AsSingle();

        Container.Bind<HeroSummonService>().AsSingle();
    }
}