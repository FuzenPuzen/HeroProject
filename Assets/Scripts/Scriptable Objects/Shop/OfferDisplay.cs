using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfferDisplay : MonoBehaviour
{

    public OfferSC offerSC;
    public Image offerImg;
    public Text offerQuantity;
    public Image costImg;
    public Text costQuantity;

    void Start()
    {
        offerImg.sprite = offerSC.offerImg;
        offerQuantity.text = offerSC.offerQuantity;
        costImg.sprite = offerSC.costImg;
        costQuantity.text = offerSC.costQuantity;
    }


}
