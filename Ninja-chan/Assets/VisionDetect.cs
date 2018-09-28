using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionDetect : MonoBehaviour {

    private bool triggerActivated = false;
    private bool triggerLimitReached = false;

    private float timeEnter = 0f;
    private float timePassed = 0f;
    private float timeAllowed = 2f;

    private void Update()
    {
        //get time passed if trigger is active
        //if time passed is greater than time max
        //player dies
        if (timeEnter != 0f)
        {
            timePassed = Time.time - timeEnter;
            if (timePassed > timeAllowed)
            {
                Debug.Log("Player is Dead.");
                timeEnter = 0f;
            }
        }
    }

    private void OnTriggerEnter(Collider o)
    {
        timeEnter = Time.time;
        Debug.Log("Triggered at " + timeEnter);
    }

    private void OnTriggerExit(Collider o)
    {
        timeEnter = 0f;
        Debug.Log("out of trigger at " + Time.time);
    }


}
