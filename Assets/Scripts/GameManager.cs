using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour
{
    public HeroPanelService heroPanelService = null;

    void Start()
    {
        
    }

    [Inject]
    public void exuct(HeroesSLDataService heroesSLDataService)
    {
        Debug.Log(heroesSLDataService.GetHeroesSLData());
    }
}
