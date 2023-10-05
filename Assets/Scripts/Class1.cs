using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Class1
{
    [Inject]
    public void Construct(Class2 cl2)
    {
        cl2.Log();
    }

    public void Log()
    {
        Debug.Log("Class1");
    }
}
