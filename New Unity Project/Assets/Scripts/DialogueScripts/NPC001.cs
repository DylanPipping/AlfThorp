using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC001 : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject NPC_Name;
    public GameObject NPC_Text;

    void Update()
    {
        TheDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            AttackBlocker.BlockSword = 1;
            ActionText.GetComponent<Text>().text = "Talk";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                AttackBlocker.BlockSword = 2;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                //ThePlayer.SetActive(false);
                StartCoroutine(NPC001_Active());
            }
        }
    }

    void OnMouseExit()
    {
        AttackBlocker.BlockSword = 0;
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

    IEnumerator NPC001_Active()
    {
        if (QuestManager.ActiveQuestNumber == 2)
        {
            TextBox.SetActive(true);
            NPC_Name.GetComponent<Text>().text = "Nobunaga";
            NPC_Name.SetActive(true);
            NPC_Text.GetComponent<Text>().text = "Welcome back! Nice job on your last quest, but I need your help once more. We have a bit of a spider problem outside the village. Please take this key and get rid of them would you? There is a reward for doing so.";
            NPC_Text.SetActive(true);
            yield return new WaitForSeconds(5.5f);
            NPC_Name.SetActive(false);
            NPC_Text.SetActive(false);
            TextBox.SetActive(false);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        else
        {
            TextBox.SetActive(true);
            NPC_Name.GetComponent<Text>().text = "Nobunaga";
            NPC_Name.SetActive(true);
            NPC_Text.GetComponent<Text>().text = "Ohayou aibou, I currently have a quest for you. Head over to the quest board to receive this Quest";
            NPC_Text.SetActive(true);
            yield return new WaitForSeconds(5.5f);
            NPC_Name.SetActive(false);
            NPC_Text.SetActive(false);
            TextBox.SetActive(false);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        
    }
}
