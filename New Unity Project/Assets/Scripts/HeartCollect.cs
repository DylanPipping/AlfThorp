using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public int rotateSpeed;
    public AudioSource CollectSound;
    public GameObject ThisHeart;

    void Update()
    {
        rotateSpeed = 2;
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    void OnTriggerEnter()
    {
        CollectSound.Play();
        HealthMonitor.healthValue += 1;
        ThisHeart.SetActive(false);

    }
}
