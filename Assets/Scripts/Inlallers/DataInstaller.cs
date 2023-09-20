using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DataInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<HeroesSODataService>().AsSingle();
        Container.Bind<HeroesSLDataService>().AsSingle();
        Container.Bind<HeroesDataService>().AsSingle();

        Container.Bind<JewelryDataService>().AsSingle(); 
    }
}
