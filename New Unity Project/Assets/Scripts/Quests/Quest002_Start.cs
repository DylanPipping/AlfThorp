using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest002_Start : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;

    
    void Update()
    {
        TheDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionText.GetComponent<Text>().text = "Open Gate";
            AttackBlocker.BlockSword = 1;
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
