using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001_Take : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject UIQuest;
    public GameObject ThePlayer;
    public GameObject NoticeCam;
    public GameObject MiniMap;

    void Update()
    {
        TheDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
       if(TheDistance <= 3)
       {
           AttackBlocker.BlockSword = 1;
           ActionDisplay.SetActive(true);
           ActionText.SetActive(true);
       }

       if(Input.GetButtonDown("Action"))
       {
           if(TheDistance <= 3)
           {
               MiniMap.SetActive(false);
               AttackBlocker.BlockSword = 2;
               Cursor.lockState = CursorLockMode.None;
               Cursor.visible = true;
               ActionDisplay.SetActive(false);
               ActionText.SetActive(false);
               UIQuest.SetActive(true);
               NoticeCam.SetActive(true);
               ThePlayer.SetActive(false);
           }
       } 
    }

    void OnMouseExit()
    {
        AttackBlocker.BlockSword = 0;
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

}
