using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Class2 
{
    [Inject]
    public void Construct(Class1 cl1, Class3 cl3)
    {
        cl1.Log();
        cl3.Log();
    }

    public void Log()
    {
        Debug.Log("Class2");
    }
}
