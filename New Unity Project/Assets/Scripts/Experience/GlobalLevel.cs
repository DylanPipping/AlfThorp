using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLevel : MonoBehaviour
{
    public static int CurrentLvl = 1;
    public int InternalLvl;

    void Update()
    {
        InternalLvl = CurrentLvl;
    }
}
