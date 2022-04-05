using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        MainGameManager.instance.AdjustScore(2300);
    }
}
