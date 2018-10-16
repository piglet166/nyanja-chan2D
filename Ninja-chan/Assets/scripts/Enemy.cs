using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character {

    private bool has_collided = false;

    private void Update()
    {
        //Enemy movement
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        //var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        //transform.Translate(0, 0, z);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            has_collided = true;
            //gameOver
        }
            
    }
}
