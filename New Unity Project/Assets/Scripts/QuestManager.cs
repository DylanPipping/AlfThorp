using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int InternalQuestNumber;
    public static int ActiveQuestNumber;
    public static int SubQuestNumber;
    public int InternalSubNumber;

    //public GameObject Main_Mark;
    //public GameObject Objective01Mark;
    //public GameObject Objective02Mark;
    //public GameObject Objective03Mark;
    //public GameObject Pointer;

    void Update()
    {
        InternalQuestNumber = ActiveQuestNumber;
        InternalSubNumber = SubQuestNumber;
        //Pointer.transform.LookAt(Main_Mark.transform);

        /*if(InternalSubNumber == 0)
        {
            Pointer.SetActive(false);
        }
        else
        {
            Pointer.SetActive(true);
        }

        if(InternalSubNumber == 1)
        {
            Main_Mark.transform.position = Objective01Mark.transform.position;
        }
        if (InternalSubNumber == 2)
        {
            Main_Mark.transform.position = Objective02Mark.transform.position;
        }
        if (InternalSubNumber == 3)
        {
            Main_Mark.transform.position = Objective03Mark.transform.position;
        }*/
    }

}
