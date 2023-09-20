using System.Reflection.Emit;
using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour
{
    private StateMachine _menuStateMachine;
    private MenuStartState _menuStartState;

    [Inject]
    private void Construct(StateMachine menuStateMachine, MenuStartState menuStartState)
    {
        _menuStateMachine = menuStateMachine;
        _menuStartState = menuStartState;
    }


    void Start()
    {
        /*PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();*/
        _menuStateMachine.SetState(_menuStartState);
    }

        /*heroesPanelService = container.Resolve<HeroesPanelService>();*/
}
