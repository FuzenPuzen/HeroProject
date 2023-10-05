using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Class3 
{

    [Inject]
    public void Construct(Class1 cl1, Class2 cl2)
    {
        cl1.Log();
        cl2.Log();
    }

    public void Log()
    {
        Debug.Log("Class3");
    }
}
