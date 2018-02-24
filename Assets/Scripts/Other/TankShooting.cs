using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    private float currentTime;
    public void Fire(int force,float rate)
    {
        currentTime += Time.deltaTime;
        if (currentTime>rate)
        {
            Debug.Log("AAA");
            currentTime = 0;
        }
    }
}
