using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class FinishLineController : MonoBehaviour
{
    [SerializeField] NavMeshAgent _playerNavMesh, _enemyNavmesh;
    [SerializeField] Text mainCoinTxt;
    int ilkGelen=0;
    public static int playerWin=0, playerLose=0;
    private void FixedUpdate()
    {
        ShopScript._sCointTxt = mainCoinTxt.text;
    }
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                //Camerayý Önden çekecek þekilde çevir
                _enemyNavmesh.speed = 0;
                ilkGelen++;
                if(ilkGelen == 1)
                {
                    StartCoroutine(WinPanelSec());
                }
                Debug.Log("Player Kazandý");
                playerWin++;
                playerCoint();
                break;
            case "Enemy":
                _playerNavMesh.speed = 0;
                ilkGelen++;
                if (ilkGelen == 1)
                {
                    StartCoroutine(LosePanelSec());
                }
                Debug.Log("Düþman Kazandý");
                playerLose++;
                playerCoint();
                break;
            default:
                ilkGelen = 0;
                break;
        }
    }
    IEnumerator WinPanelSec()
    {
        yield return new WaitForSeconds(1f);
        Main._sWinPanel.SetActive(true);
        
    }
    IEnumerator LosePanelSec()
    {
        yield return new WaitForSeconds(1f);
        Main._sLosePanel.SetActive(true);
    }
    public void playerCoint()
    {
        switch (playerWin)
        {
            case 1:
                mainCoinTxt.text = "150";
                break;
            case 2:
                mainCoinTxt.text = "400";
                break;
            case 3:
                mainCoinTxt.text = "900";
                break;
            case 4:
                mainCoinTxt.text = "2000";
                break;
        }
        switch (playerLose)
        {
            case 1:
                mainCoinTxt.text = "0";
                break;
            case 2:
                mainCoinTxt.text = "150";
                break;
            case 3:
                mainCoinTxt.text = "400";
                break;
            case 4:
                mainCoinTxt.text = "900";
                break;
        }

    }
}
