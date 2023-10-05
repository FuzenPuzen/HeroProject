using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TestInst : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Class1>().AsSingle();
        Container.Bind<Class2>().AsSingle();
        Container.Bind<Class3>().AsSingle();

    }
}
