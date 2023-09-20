using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroUnitView : MonoBehaviour
{
    public int id;

    public void MoveToTarget(GameObject target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 1f);
    }

}
