using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.AI;
public class Main : MonoBehaviour
{
    [SerializeField] GameObject winPanel, losePanel,gamePanel,shopPanel;
    public static GameObject _sWinPanel,_sLosePanel,_sGamePanel;
    [SerializeField] int thisLevelCount;
    [SerializeField] int nextLevelCount;
    public static int _sThisLevelCount;
    public static int _sNextLevelCount;
    [SerializeField] Text speedTxt;
    float speedFloat;
    public static float _sSpeedFloat;
    void Start()
    {
        _sWinPanel = winPanel;
        _sLosePanel = losePanel;
        _sThisLevelCount = thisLevelCount;
        _sNextLevelCount = nextLevelCount;
    }
    private void FixedUpdate()
    {
        speedFloat = System.Convert.ToInt32(NavMeshPlayer.playerCarSpeed);
        speedTxt.text = speedFloat.ToString();
        _sSpeedFloat = speedFloat;
       
    }
    public void NextBtn()
    {
        SceneManager.LoadScene(nextLevelCount);
    }
    public void TryAgainBtn()
    {
        SceneManager.LoadScene(thisLevelCount);
    }
}
