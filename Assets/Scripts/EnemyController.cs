using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void Start()
    {
        MainGameManager.instance.AdjustScore(-1000);
    }
}
