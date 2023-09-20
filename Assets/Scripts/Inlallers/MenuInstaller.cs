using UnityEngine;
using Zenject;

public class MenuInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<HeroesPanelService>().AsSingle();

        Container.Bind<JewerlyPanelService>().AsSingle();

        Container.Bind<HeroSummonService>().AsSingle();

        Container.Bind<StateMachine>().AsSingle();

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