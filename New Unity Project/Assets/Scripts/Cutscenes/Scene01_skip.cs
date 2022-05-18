using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01_skip : MonoBehaviour
{
    public GameObject FadeInScene;

    void Start()
    {
        StartCoroutine(FadeQuit());
    }

    IEnumerator FadeQuit()
    {
        yield return new WaitForSeconds(1);
        FadeInScene.SetActive(false);
    }

    
}
