using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

    //private Kunai kunai;

	// Use this for initialization
	protected override void Start () {

        base.Start();
	}
	
	// Update is called once per frame
	protected override void Update () {

        GetInput();

        base.Update();
	}


    private void GetInput(){

        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W)) {
            direction += Vector2.up;
        }
        if(Input.GetKey(KeyCode.A)) {
            direction += Vector2.left;
        }
        if(Input.GetKey(KeyCode.S)) {
            direction += Vector2.down;
        }
        if(Input.GetKey(KeyCode.D)) {
            direction += Vector2.right;
        }

        /*if(Input.GetKey(KeyCode.L)){
            //enter dash state
         }
         if(Input.GetKey(KeyCode.J)){
            //player attacks
            attack()
         }
         if(Input.GetKey(KeyCode.K)){
            //create smoke bomb effect
            createSmokeBomb()
         }
         if(Input.GetKey(KeyCode.Space(?))){
            //creates kunai
            createKunai()
         }
         */
    }

    /*private void dashMovement() {
     * 
     * //press L to create Dash state
     * }*/

    private void createSmokeBomb() {}

    private void createKunai() {}

    private void attack() {}
}
