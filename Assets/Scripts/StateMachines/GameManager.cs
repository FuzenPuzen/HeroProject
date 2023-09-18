using System.Reflection.Emit;
using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour
{
    public HeroesPanelService heroesPanelService = null;
    private MenuStateMachine _menuStateMachine;
    private MenuStartState _menuStartState;

    [Inject] DiContainer container;
    private JewelryDataService _jewelryDataService;
    private HeroSummonService _heroSummonService;

    [Inject]
    private void Construct(MenuStateMachine menuStateMachine, MenuStartState menuStartState)
    {
        _menuStateMachine = menuStateMachine;
        _menuStartState = menuStartState;
    }


    void Start()
    {
        /*PlayerPrefs.DeleteAll();
         PlayerPrefs.Save();*/
        /*heroesPanelService = container.Resolve<HeroesPanelService>();
        _jewelryDataService = container.Resolve<JewelryDataService>();*/

        _menuStateMachine.SetState(_menuStartState);
    }

}
