using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveController : MonoBehaviour
{
    [SerializeField]NavMeshAgent playerNMA;
    [SerializeField] float carSpeed;
    float inSpeed;
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            switch (Main._sThisLevelCount)
            {
                case 1:
                    if (Main._sSpeedFloat <= 120)
                    {
                        playerNMA.speed += carSpeed * Time.deltaTime;
                    }
                    break;
                case 2:
                    if (Main._sSpeedFloat <= 150)
                    {
                        playerNMA.speed += carSpeed * Time.deltaTime;
                    }
                    break;
                case 3:
                    if (Main._sSpeedFloat <= 170)
                    {
                        playerNMA.speed += carSpeed * Time.deltaTime;
                    }
                    break;
            }
        }
    }
}
