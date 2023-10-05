using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Clmono : MonoBehaviour
{
    public Class3 cl3;
    [Inject] public DiContainer container;

    void Start()
    {
        cl3 = container.Resolve<Class3>();
    }


}
