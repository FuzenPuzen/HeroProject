using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroUnitView : MonoBehaviour
{
    [SerializeField] private int id;

    public int Id { get => id; set => id = value; }

    public void MoveToTarget(GameObject target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 1f);
    }

}
