using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour {
    public Rigidbody2D player;
    public float speed = .8f;
    public float force_jump = 300;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        runningPlayer();
	}
    public void runningPlayer () {
        player.velocity = new Vector2(speed, player.velocity.y);
        if (Input.GetMouseButtonDown(0)) { jump(); }
    }
    public void jump() {
        player.AddForce(Vector2.up * force_jump);
    }
}
