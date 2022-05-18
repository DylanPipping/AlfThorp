using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{
    public int EnemyHealth = 15;
    public GameObject TheSpider;
    public int SpiderStatus;
    public int BaseExp = 10;
    public int CalculatedExp;
    public SpiderAI SpiderAIScript;
    public static int GlobalSpider;

    void Start()
    {
        SpiderAIScript = GetComponent<SpiderAI>();   
    }

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;

    }

    void Update()
    {
        GlobalSpider = SpiderStatus;
        if(EnemyHealth <= 0)
        {
            if(SpiderStatus == 0)
            {
                StartCoroutine(DeathSpider());
            }  
        }
    }

    IEnumerator DeathSpider()
    {
        SpiderAIScript.enabled = false;
        SpiderStatus = 6;
        CalculatedExp = BaseExp * GlobalLevel.CurrentLvl;
        GlobalXP.CurrentExp += CalculatedExp;
        yield return new WaitForSeconds(0.5f);
        TheSpider.GetComponent<Animation>().Play("die");
    }
}
