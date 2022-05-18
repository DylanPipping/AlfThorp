using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalXP : MonoBehaviour
{
    public static int CurrentExp;
    public int InternalExp;

    void Update()
    {
        InternalExp = CurrentExp;
    }
}
