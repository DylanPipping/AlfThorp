using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001_Complete : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject UIQuest;
    public GameObject ThePlayer;
    public GameObject ExMark;
    public GameObject CompleteTrigger;


    void Update()
    {
        TheDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
       if(TheDistance <= 3)
       {
           ActionDisplay.SetActive(true);
           ActionText.SetActive(true);
           ActionText.GetComponent<Text>().text = "Complete Quest";
       }

       if(Input.GetButtonDown("Action"))
       {
           if(TheDistance <= 3)
           {
                QuestManager.SubQuestNumber = 0;
                GlobalCash.GoldAmount += 100;
                PlayerPrefs.SetInt("GoldAmountSave", GlobalCash.GoldAmount);
                QuestManager.ActiveQuestNumber = 2;
                ExMark.SetActive(false);
                GlobalEXP.CurrentExp += 100;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                CompleteTrigger.SetActive(false);
           }
       } 
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

}
