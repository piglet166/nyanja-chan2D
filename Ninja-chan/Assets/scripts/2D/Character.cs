using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

    //Character speed
    [SerializeField]
    private float speed;

    //Character direction
    protected Vector2 direction;

    //access Rigidbody in physics engine
    private Rigidbody2D myRigidbody;

    //access the Character animation
    private Animator myAnimator;

    /*public bool IsMoving() {

        get {
            return direction.x != 0 || direction.y != 0;
        }
    }*/

    // Use this for initialization
    protected virtual void Start () {

        myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	protected virtual void Update () {

        
	}

    private void FixedUpdate() {

        Move();
    }

    public void Move(){

        myRigidbody.velocity = direction.normalized * speed;
    }

    public void HandleLayers() {

    }

    public void AnimateMovement (Vector2 direction){

    }

    public void ActivateLayer() {

    }

    
}
