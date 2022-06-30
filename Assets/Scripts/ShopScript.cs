using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{

    [SerializeField] GameObject shopPanel,StartPanel;
    [SerializeField] Text coinTxt, shopPanelCointText;
    public static string _sCointTxt;
    [SerializeField] Button car1, car2, car3, car4, car5;
    public static int carNumber;
    private void FixedUpdate()
    {
        _sCointTxt = coinTxt.text;

    }
    public void ShopBtn()
    {
        shopPanel.SetActive(true);
        StartPanel.SetActive(false);
        shopPanelCointText.text = _sCointTxt;
    }
    public void ClosseShopBtn()
    {
        shopPanel.SetActive(false);
        StartPanel.SetActive(true);
    }
    public void car1Btn()
    {
        carNumber = 1;
        ShopPanelCarBuy();
    }
    public void car2Btn()
    {
        carNumber = 2;
        ShopPanelCarBuy();
    }
    public void car3Btn()
    {
        carNumber = 3;
        ShopPanelCarBuy(); 
    }
    public void car4Btn()
    {
        carNumber = 4;
        ShopPanelCarBuy();
    }
    public void car5Btn()
    {
        carNumber = 5;
        ShopPanelCarBuy();
    }
    public void ShopPanelCarBuy()
    {
        switch (_sCointTxt)
        {
            case "0":
                car1.interactable = true;
                Debug.Log("car1 seçildi");
                break;
            case "150":
                car2.interactable = true;
                break;
            case "400":
                car3.interactable = true;
                break;
            case "900":
                car4.interactable = true;
                break;
            case "2000":
                car5.interactable = true;
                break;
        }
    }
}
