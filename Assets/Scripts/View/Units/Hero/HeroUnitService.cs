using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroUnitService : UnitService
{
    private HeroUnitView _heroUnitView;

    public HeroUnitService(HeroUnitView heroUnitView)
    {
        _heroUnitView = heroUnitView;
    }



}
