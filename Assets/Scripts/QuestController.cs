using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{

    public int enemyCount;
    public GameObject pustushka;

    void Start()
    {
        pustushka.SetActive(false);
    }

    public void ReduceEnemyCount()
    {
        enemyCount -= 1;

        if (enemyCount <= 0)
        {
            pustushka.SetActive(true);
        }
    }
}
