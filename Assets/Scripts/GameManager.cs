using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour
{
    public HeroesPanelService heroesPanelService = null;

    [Inject] DiContainer container;
    private JewelryDataService _jewelryDataService;
    private HeroSummonService _heroSummonService;


    void Start()
    {
        /*PlayerPrefs.DeleteAll();
         PlayerPrefs.Save();*/

         /*heroesPanelService = container.Resolve<HeroesPanelService>();
         _jewelryDataService = container.Resolve<JewelryDataService>();*/
        _heroSummonService = container.Resolve<HeroSummonService>();
       
        

    }

}
