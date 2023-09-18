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

        Container.Bind<MenuStateMachine>().AsSingle();

        Container.Bind<MenuStartState>().AsSingle();
        Container.Bind<HeroesState>().AsSingle();
        Container.Bind<RaidState>().AsSingle();
        Container.Bind<ShopState>().AsSingle();

        Container.Bind<NavigationPagesService>().AsSingle();
        Container.Bind<RaidPageService>().AsSingle();
        Container.Bind<HeroPageService>().AsSingle();
        Container.Bind<ShopPageService>().AsSingle();
    }
}